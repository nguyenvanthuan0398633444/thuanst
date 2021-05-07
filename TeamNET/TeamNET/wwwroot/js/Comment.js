var saveObj = {};
saveObj.commentId = 0;
saveObj.eventContentId = $('#EventContentId').val();
saveObj.userId = $('#UserId').val();
saveObj.text = $('#mycomment').val();
var statusId = $('#statusId').val();
//saveObj.realTime = new Date(saveObj.realTime + " UTC");
var hashtags = document.getElementsByClassName('mentiony-link');
var Ability = '';
if (hashtags.length != 0) {
    for (let i = 0; i < hashtags.length; i++) {
        if (i == 0)
            Ability = hashtags[i].dataset.itemId;
        else
            Ability += hashtags[i].dataset.itemId;
    }
}

var role = 0;
var userId = $('#UserId').val();
$.ajax({
    method: "GET",
    url: "/Account/GetRole/" + userId,
    dataType: "json",
    success: function (response) {
        role = response;
    }
});

async function saveAbility() {
    await fncinit();
    var Ability = '';
    var eventContendId = parseInt($('#EventContentId').val());
    var hashtags = document.getElementsByClassName('mentiony-link');
    if (hashtags.length > 0) {
        for (let i = 0; i < hashtags.length; i++) {
            if (i == 0)
                Ability = hashtags[i].dataset.itemId;
            else
                Ability += "," + hashtags[i].dataset.itemId;
        }
    }
    else {
        Ability = "0";
    }
    await $.ajax({
        url: `/Ability/SaveAbility/${eventContendId}/${Ability}`,
        method: 'Post',
        dataType: "json",
        success: function () { }
    });

}

async function fncinit() {
    await $.ajax({
        url: `/Comment/GetsComment/${saveObj.eventContentId}`,
        method: 'Get',
        dataType: "json",
        success: function (response) {
            $('#comment').empty();
            $.each(response, function (i, v) {
                if (v.userId == saveObj.userId) {
                    $('#comment').append(`
                    <div class="comment-right row">
                        <div class="content-comment" style="background-color:white">
                            <div>
                                <div class="triangle-left-top">
                                    <h5>${v.userName}</h5>
                                    <div class="edit-delete">
                                        <i class="fas fa-pen" onclick="EditComment(${v.commentId})"></i>
                                        <i class="far fa-trash-alt" onclick="DeleteComment(${v.commentId})"></i>
                                    </div>

                                </div>
                                <div id="${v.commentId}">${v.text}</div>
                                <p class="conten-date">${v.realTime.substring(0, 10)} - ${v.realTime.substring(11, 19)}</p>
                            </div>
                        </div>
                        <div class="triangle-right"></div>
                        <div class="avata">
                            <img class="avata-img" src="/img/${v.avatar}" alt="">
                            <p class="${v.roleName}">${v.roleName}</p>
                        </div>
                    </div>`);
                }
                else {
                    $('#comment').append(`
                        <div class="comment-left row">
                            <div class="avata">
                                <img class="avata-img" src="/img/${v.avatar}" alt="">
                                    <p class="${v.roleName}">${v.roleName}</p>
                            </div>
                            <div class="triangle-left"></div>
                            <div class="content-comment">
                                <div>
                                    <div class="triangle-left-top">
                                        <h5>${v.userName}</h5>                                                    
                                    </div>
                                    <p>${v.text}</p>
                                    <p class="conten-date">${v.realTime.substring(0, 10)} - ${v.realTime.substring(11, 19)}</p>
                                </div>
                            </div>
                        </div>`);
                }

            });

        }
    });
}

$(document).ready(async function () {
    await fncinit();
    document.getElementById("comment").scrollTop = document.getElementById("comment").scrollHeight;
    var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();

    //Disable send button until connection is established
    document.getElementById("sent").disabled = true;

    connection.on("ReceiveMessage", async function () {
        await fncinit();
    });

    connection.start().then(function () {
        document.getElementById("sent").disabled = false;
    }).catch(function (err) {
        return console.error(err.toString());
    });

    document.getElementById("sent").addEventListener("click", async function (event) {
        saveObj.text = $('.emojionearea-editor')[0].innerHTML;
        $.ajax({
            url: '/Comment/SaveComment',
            method: 'POST',
            data: saveObj,
            success: function (response) {
                saveObj.commentId = 0;
                $('.emojionearea-editor').text('');
                $('#mycomment').val('');
                $("#cancel").attr("hidden", "");
            }
        });
        await fncinit();
        await saveAbility();
        document.getElementById("comment").scrollTop = document.getElementById("comment").scrollHeight;

        connection.invoke("Send").catch(function (err) {
            return console.error(err.toString());
        });;

        event.preventDefault();
    });
});


function DeleteComment(commentId) {
    var r = confirm("削除してもよろしいですか");
    if (r == true) {
        var contains = document.getElementById(commentId).innerHTML;
        if (statusId > 2 && contains.includes('mentiony-link')) {
            alert("イベントコンテンツが完了または削除されました");
        }
        else {
            var id = commentId;
            var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();
            connection.on("ReceiveMessage", async function () {
                await fncinit();
            });

            $.ajax({
                url: `/Comment/DeleteComment/${id}`,
                method: 'POST',
                success: function (response) {
                }
            });

            connection.start().then(() => {
                connection.invoke("Send").catch(function (err) {
                    return console.error(err.toString());
                });
                saveAbility();

            });
            event.preventDefault();
        }
    }
}
function EditComment(commentId) {
    var contains = document.getElementById(commentId).innerHTML;
    if (statusId > 2 && contains.includes('mentiony-link')) {
        alert("イベントコンテンツが完了または削除されました");
    }
    else {
        saveObj.commentId = commentId;
        saveObj.text = document.getElementById(commentId).innerHTML;
        document.getElementsByClassName('emojionearea-editor mentiony-content')[0].innerHTML = saveObj.text;
        document.getElementById('cancel').removeAttribute("hidden");
    }
}
$('#cancel').click(function () {
    saveObj.commentId = 0;
    $('.emojionearea-editor').text('');
    $('#mycomment').val('');
    $("#cancel").attr("hidden", "");
});