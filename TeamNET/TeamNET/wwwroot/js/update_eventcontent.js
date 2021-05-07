var item_event = document.getElementsByClassName("item-event");
var questions = document.getElementsByClassName('question');

for (var i in item_event) {
    if (item_event[i].value != null)      
    questions[i].classList.add('show');  
}
var cancel = $('.cancel');
var id = $('#EventContentId').val();
cancel.click(function () {
    
    $.ajax({
        url: `/eventContent/get/${id}`,
        method: 'GET',
        dataType: 'JSON',
        success: function (response) {
            $('#list-event').val(response.data.eventId);
            $('#event').val(response.data.communityAbility);
            $('#action').val(response.data.actionAbility);
            $('#power').val(response.data.demonstratedAbility);
            $('#ability').val(response.data.selfDevelopment);
            $('#thought').val(response.data.thinkingAbility);
        }
    });
});
