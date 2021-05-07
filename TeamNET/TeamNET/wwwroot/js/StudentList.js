
var student = {} || student;
var studentName = $('#studentName').val();
var course = $('#course').val();

var dataAbility = [];
var arrId = [];
var events = $('#event').val();
var tam = $('#AbilityIds').val();
var table = $('#myTable').DataTable();
var UserId = $('#UserId').val();
var RoleName = $('#RoleName').val();

for (var i = 0; i < tam.length; i++) {
    if (i == 0) {
        ability = tam[i];
    }
    else
        ability +=","+ tam[i];
}
$(document).ready(function () {

    student.init();
});
student.init = function () {
    student.drawTable();
    student.GetData();

}

function Events(userId, courseCurrentId) {
    $(`#${userId}${courseCurrentId}`).empty();
    $(`#${userId}${courseCurrentId}`).append(`<div class="test" id = "${userId}${courseCurrentId}6"></div>`)
    $.ajax({
        url: `/Student/EventList/${userId}/${courseCurrentId}`,
        method: "GET",
        dataType: "json",
        success: function (data) {
            $.each(data, function (i, v) {
                if (i == data.length - 1) {
                    $(`#${userId}${courseCurrentId}6`).append(`<span>${v.eventName}</span>`);
                }
                else {
                    $(`#${userId}${courseCurrentId}6`).append(`<span>${v.eventName}, </span>`);
                }
            })
        }
    });
}

student.drawTable = function () {
    $('#myTable>tBody').empty();
    function Ability(userId, courseCurrentId) {
        $(`#${userId}${courseCurrentId}1`).empty();
        $(`#${userId}${courseCurrentId}1`).append(`<div class="test" id = "${userId}${courseCurrentId}5"></div>`);
        $.ajax({
            url: `/Student/AbilityList/${userId}/${courseCurrentId}`,
            method: "GET",
            dataType: "json",
            success: function (data) {
                $.each(data, function (i, v) {
                    if (i == data.length - 1) {
                        $(`#${userId}${courseCurrentId}5`).append(`<strong style="color:${v.color}">${v.abilityName}</strong>`);
                    }
                    else {
                        $(`#${userId}${courseCurrentId}5`).append(`<strong style="color:${v.color}">${v.abilityName}, </strong>`);
                    }                  
                })
            }
        });
    }
    $.ajax({
        url: `/StudentList/${UserId}`,
        method: "GET",
        dataType: "json",
        success: function (data) {
            table.clear().destroy();
            $.each(data, function (i, v) {
                if (RoleName == 'Doctor' || RoleName == 'Teacher') {
                $('#myTable>tBody').append(
                    `<tr ondblclick="dbclick('${v.userId}')">
                        <th scope="row">${v.studentCode}</th>
                        <td>${v.studentName}</td>
                        <td id="${v.userId}${v.courseCurrentId}" style="text-align: left;"></td>
                        <td id="${v.userId}${v.courseCurrentId}1" style="text-align: left;"></td>
                        <td><a href="/Tracking/Index/${v.userId}"><i class="las la-chart-bar"></i></a></td>
                    </tr>`
                );
                Events(v.userId, v.courseCurrentId);
                Ability(v.userId, v.courseCurrentId);
                }
                else {
                    $('#myTable>tBody').append(
                        `<tr ondblclick="dbclick('${v.userId}')">
                        <th scope="row">${v.studentCode}</th>
                        <td>${v.studentName}</td>
                        <td id="${v.userId}${v.courseCurrentId}" style="text-align: left;"></td>
                        <td id="${v.userId}${v.courseCurrentId}1" style="text-align: left;"></td>
                      
                    </tr>`
                    );
                    Events(v.userId, v.courseCurrentId);
                    Ability(v.userId, v.courseCurrentId);
                }
                
            });
            student.draw();
        }
    });
}
student.draw = function () {
    table = $('#myTable').DataTable({
        "searching": false,
        "ordering": false,

        "language": {
            "emptyTable": "テーブルにデータがありません",
            "info": " _TOTAL_ 件中 _START_ から _END_ まで表示",
            "infoEmpty": " 0 件中 0 から 0 まで表示",
            "infoFiltered": "（全 _MAX_ 件より抽出）",
            "infoThousands": ",",
            "lengthMenu": "_MENU_ 件表示",
            "loadingRecords": "読み込み中...",
            "processing": "処理中...",
            "search": "検索:",
            "zeroRecords": "一致するレコードがありません",
            "paginate": {
                "first": "先頭",
                "last": "最終",
                "next": "次",
                "previous": "前"
            },
            "lengthMenu": "_MENU_ 表示",
        },

    });
}
function dbclick(userId) {
    window.location.href = '/Student/Details/' + userId;
}
var itemTemplateShow = function (item) {
    return (
        `<strong style="color: ${item.color}">${item.abilityName}</strong>`
    );
}
var displayExprShow = function (item) {
    arrId = $('#AbilityIds').val();
    arrId.push(item.abilityId);
    $('#AbilityIds').val(arrId).change();
    setTimeout(function () {
        $('#html-editor p').empty();
    }, 50);
    return (
        item.abilityName
    );
};
student.mentions = function () {  
    $("#html-editor").dxHtmlEditor({
        mentions: [{
            marker: "#",
            dataSource: dataAbility,
            searchExpr: "abilityName",
            valueExpr: "abilityId",
            itemTemplate: itemTemplateShow,
            displayExpr: displayExprShow
        }]
    });
};

student.GetData = function () {  
    $.ajax({
        url: "/Ability/Gets",
        method: 'GET',
        dataType: 'JSON',      
        success: function (response) {
            dataAbility = response;       
            student.mentions();
        }
    });
    
}
var changeAbility = async function () {
    var Abilitys = $('#AbilityIds').val();
    var result = [];
    await $.ajax({
        url: "/Ability/Gets",
        method: 'GET',
        dataType: 'JSON',
        success: function (response) {
            for (let i = 0; i < response.length; i++) {
                if (Abilitys.indexOf(response[i].abilityId.toString()) < 0) {
                    result.push(response[i]);
                }
            }
            dataAbility = result;
        }
    });

    $("#html-editor").dxHtmlEditor({
        mentions: [{
            marker: "#",
            dataSource: dataAbility,
            searchExpr: "abilityName",
            valueExpr: "abilityId",
            itemTemplate: itemTemplateShow,
            displayExpr: displayExprShow
        }]
    });
}

$('#search').click(function () {
    var studentName = $('#studentName').val();
    var course = parseInt($('#course').val());
    var ability = "";
    var events = parseInt($('#event').val());
    var tam = $('#AbilityIds').val();
    tam.sort(function (a, b) {
        return a - b;
    });
    var table = $('#myTable').DataTable();
    var UserId = $('#UserId').val();
    for (var i = 0; i < tam.length; i++) {
        if (i == 0) {
            ability = tam[i];
        }
        else
            ability += "," + tam[i];
    }
    if (studentName == null || studentName == "") {
        studentName = "!!!!!";
    }
    if (course == null || course == "") {
        course = 0;
    }
    if (ability == null || ability == "") {
        ability = "!!!!!";
    }
    if (events == null || events == "") {
        events = 0;
    }
    $('#myTable>tBody').empty();
    function Ability(userId, courseCurrentId) {
        $(`#${userId}${courseCurrentId}1`).empty();
        $(`#${userId}${courseCurrentId}1`).append(`<div class="test" id = "${userId}${courseCurrentId}5"></div>`);
        $.ajax({
            url: `/Student/AbilityList/${userId}/${courseCurrentId}`,
            method: "GET",
            dataType: "json",
            success: function (data) {
                $.each(data, function (i, v) {
                    if (i == data.length - 1) {
                        $(`#${userId}${courseCurrentId}5`).append(`<strong style="color:${v.color}">${v.abilityName}</strong>`);
                    }
                    else {
                        $(`#${userId}${courseCurrentId}5`).append(`<strong style="color:${v.color}">${v.abilityName}, </strong>`);
                    }  
                })
            }
        });
    }
    $.ajax({
        url: `/StudentList/${UserId}/${studentName}/${events}/${ability}/${course}`,
        method: "GET",
        dataType: "json",
        success: function (data) {
            table.clear().destroy();
            $.each(data, function (i, v) {
                if (RoleName == 'Doctor' || RoleName == 'Teacher') {
                    $('#myTable>tBody').append(
                        `<tr ondblclick="dbclick('${v.userId}')">
                        <th scope="row">${v.studentCode}</th>
                        <td>${v.studentName}</td>
                        <td id="${v.userId}${v.courseCurrentId}" style="text-align: left;"></td>
                        <td id="${v.userId}${v.courseCurrentId}1" style="text-align: left;"></td>
                        <td><a href="/Tracking/Index/${v.userId}"><i class="las la-chart-bar"></i></a></td>
                    </tr>`
                    );
                    Events(v.userId, v.courseCurrentId);
                    Ability(v.userId, v.courseCurrentId);
                }
                else {
                $('#myTable>tBody').append(
                    `<tr ondblclick="dbclick('${v.userId}')">
                        <th scope="row">${v.studentCode}</th>
                        <td>${v.studentName}</td>
                        <td id="${v.userId}${v.courseCurrentId}" style="text-align: left;"></td>
                        <td id="${v.userId}${v.courseCurrentId}1" style="text-align: left;"></td>
                       
                    </tr>`
                );
                Events(v.userId, v.courseCurrentId);
                Ability(v.userId, v.courseCurrentId);
                }
            });
            student.draw();
        }
    });
});
var body = document.getElementsByTagName('body')[0];
var hashtag = document.getElementsByClassName('hashtag_label');
var hastagEditor = document.getElementById('html-editor');
var tagName = document.getElementsByClassName('table-top');
var tagName1 = document.getElementsByClassName('row-border');


hastagEditor.onclick = function () {
    hashtag[0].classList.add('hide');
}
tagName[0].onclick = function () {
    hashtag[0].classList.remove('hide');
}
tagName1[0].onclick = function () {
    hashtag[0].classList.remove('hide');
}
var width1 = $(window).width();
if (width1 < 600) {
    hashtag[0].innerHTML = '#';
}
body.onresize = function () {
    var width = $(window).width();
    if (width < 600 || width1<600) {
        hashtag[0].innerHTML = '#';
    } else {
        hashtag[0].innerHTML = '#ハッシュタグ';
    }
}
