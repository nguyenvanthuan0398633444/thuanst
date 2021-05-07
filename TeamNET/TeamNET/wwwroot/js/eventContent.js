//var eventContent = {} || eventContent;

//eventContent.updateEvent = function () {
//    if ($('#formAddEditStudentPoint').valid() && check) {
//        var saveObj = {};
//        saveObj.isUpdate = isUpdate;
//        saveObj.studentId = $('#StudentId').val();
//        saveObj.subjectId = parseInt($('#Subjects').val());
//        saveObj.coefficient = parseInt($('#Coefficients').val());
//        saveObj.score = parseFloat($('#Score').val() == '' ? 0 : $('#Score').val());
//        saveObj.scores = $('#ScoresStr').val();
//        $.ajax({
//            url: '/transcript/saveStudentPoint',
//            method: 'POST',
//            dataType: 'JSON',
//            contentType: 'application/json',
//            data: JSON.stringify(saveObj),
//            success: function (response) {
//                if (response.data.transcriptId > 0) {
//                    bootbox.alert(`<h5 class="text-success">${response.data.message} !!!</h5>`, function () {
//                        transcript.drawInfoStudent($('#StudentId').val());
//                        $('#Coefficients').val('');
//                        $('#Score').val('');
//                        $('#ScoresStr').val('');
//                        transcript.changeCoefficient(saveObj.studentId, saveObj.subjectId);
//                    });
//                } else {
//                    $('#msgResult').text(`${response.data.message}`);
//                    $('#msgResult').show();
//                }
//            }
//        });
//    } else {

//    }

//}