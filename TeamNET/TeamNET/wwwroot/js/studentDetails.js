var student = {} || student;
var tableStudentDetails = $('#tbStudentDetails').DataTable();
var studentId = $('#StudentId').val();
var userCurrentId = $('#UserCurrentId').val();
var rolesUser = [];
var isSearch = false;
student.currentPage = 0;
student.showData = function () {
    isSearch = false;
    $.ajax({
        url: `/student/get/${studentId}`,
        method: 'GET',
        dataType: 'JSON',
        success: function (response) {
            student.currentPage = tableStudentDetails.page.info().page > 0 ? tableStudentDetails.page.info().page : 0;
            tableStudentDetails.clear().destroy();
            $('#tbStudentDetails>tbody').empty();
            $.each(response.data, function (i, v) {
                var row = "";
                if (rolesUser.includes("Student")) {
                    switch (v.statusId) {
                        case 3:
                            {
                                row = ` <td>
                                            <i style="font-size: 25px; color: #a3c2c2" class="las la-pen-alt"></i>
                                           <i style="font-size: 25px; color: #a3c2c2" class="las la-trash"></i>
                                         </td>`;
                                break;
                            }
                        default:
                            {
                                row = ` <td>
                                            <a href="/eventContent/update/${v.eventContentId}"><i style="font-size: 25px; color: #161414" class="las la-pen-alt"></i></a>
                                            <a href='javascript: void(0)' onclick='student.delete("${v.eventContentId}")' title='削除'>
                                                <i style="font-size: 25px; color: red" class="las la-trash"></i>
                                            </a>
                                         </td>`;
                                break;
                            }
                    }

                } else if (rolesUser.includes("Doctor")) {
                    switch (v.statusId) {
                        case 2:
                            {
                                row = ` <td>
                                            <a href='javascript: void(0)' onclick='student.changeStatus("${v.eventContentId}", 3)' title='修了'>
                                                <i style="font-size: 18px; color:#00BFFF" class="fas fa-check"></i>
                                            </a>
                                         </td>`;
                                break;
                            }
                        case 3:
                            {
                                row = ` <td>
                                           <i style="font-size: 18px; color:#a3c2c2" class="fas fa-check"></i>
                                         </td>`;
                                break;
                            }
                        default:
                            {
                                row = ` <td>
                                         </td>`;
                                break;
                            }
                    }
                }
                $('#tbStudentDetails>tbody').append(
                    `<tr>
                        <td scope="row" style="font-size: 20px;">
                           ${v.courseName}
                        </td>
                        <td class="text-left"><label><i class="${v.eventIcon} mr-2"></i> ${v.eventName}</label></td>
                        <td class="text-center">
                            <a class="${(v.statusId == 1 ? "button5" : (v.statusId == 2 ? "button6" : "button4"))}">
                                ${v.statusName}
                            </a>
                         </td>
                        <td>
                            <a href="/eventcontent/update/${v.eventContentId}" class="notification">
                                <i style="font-size: 30px; color: #00BFFF" class="far fa-bell"></i>
                                ${v.countNotification == 0 ? "" : '<span class="badge">' + v.countNotification + '</span>'}
                            </a>
                        </td>
                        ${row}
                    </tr>`
                );
            });
            student.drawDataTable();
        }
    });
}

student.changeStatus = function (id, statusId) {
    var statusName = "";
    if (statusId == 3) {
        statusName = "修了";
    }
    bootbox.confirm({
        title: '<h4 class="text-danger">お知らせ</h4>',
        message: `このイベントを <b class="text-success">${statusName}しますか？</b> `,
        buttons: {
            cancel: {
                label: '<i class="fa fa-times"></i> いいえ',
                className: 'btn-danger'
            },
            confirm: {
                label: '<i class="fa fa-check"></i> はい',
                className: 'btn-success'
            }
        },
        callback: function (result) {
            if (result) {
                $.ajax({
                    url: `/eventContent/changeStatus/${id}/${statusId}`,
                    method: "PATCH",
                    contentType: 'JSON',
                    success: function (response) {
                        if (response.data.isSuccess) {
                            bootbox.alert(`<h5 class="text-success">${response.data.message} !!!</h5>`, function () {
                                if (isSearch) {
                                    student.seacherEvent();
                                } else {
                                    student.showData();
                                }
                            });
                        } else {
                            bootbox.alert(`<h5 class="text-danger">${response.data.message} !!!</h5>`);
                        }
                    }
                });
            }
        }
    });
}

student.delete = function (id) {
    bootbox.confirm({
        title: '<h4 class="text-danger">お知らせ</h4>',
        message: `このイベントを<b class="text-danger">削除しますか</b>？ `,
        buttons: {
            cancel: {
                label: '<i class="fa fa-times"></i> いいえ',
                className: 'btn-success'
            },
            confirm: {
                label: '<i class="fa fa-check"></i> はい',
                className: 'btn-danger'
            }
        },
        callback: function (result) {
            if (result) {
                $.ajax({
                    url: `/eventContent/delete/${id}`,
                    method: "PATCH",
                    contentType: 'JSON',
                    success: function (response) {
                        if (response.data.isSuccess) {
                            bootbox.alert(`<h5 class="text-success">${response.data.message} !!!</h5>`, function () {
                                if (isSearch) {
                                    student.seacherEvent();
                                } else {
                                    student.showData();
                                }
                            });
                        } else {
                            bootbox.alert(`<h5 class="text-danger">${response.data.message} !!!</h5>`);
                        }
                    }
                });
            }
        }
    });
}
student.seacherEvent = function () {
    isSearch = true;
    var saveObj = {};
    saveObj.statuses = student.getSearchStatus().length > 0 ? student.getSearchStatus() : [];
    saveObj.courseId = parseInt($('#Course').val()) > 0 ? parseInt($('#Course').val()) : 0;
    saveObj.eventId = parseInt($('#Event').val()) > 0 ? parseInt($('#Event').val()) : 0;
    saveObj.studentId = studentId;
    $.ajax({
        url: '/student/searchStudentEvent',
        method: 'POST',
        dataType: 'JSON',
        contentType: 'application/json',
        data: JSON.stringify(saveObj),
        success: function (response) {
            student.currentPage = tableStudentDetails.page.info().page > 0 ? tableStudentDetails.page.info().page : 0;
            tableStudentDetails.clear().destroy();
            $('#tbStudentDetails>tbody').empty();
            $.each(response.data, function (i, v) {
                var row = "";
                if (rolesUser.includes("Student")) {
                    switch (v.statusId) {
                        case 3:
                            {
                                row = ` <td>
                                            <i style="font-size: 25px; color: #a3c2c2" class="las la-pen-alt"></i>
                                           <i style="font-size: 25px; color: #a3c2c2" class="las la-trash"></i>
                                         </td>`;
                                break;
                            }
                        default:
                            {
                                row = ` <td>
                                            <a href="/eventContent/update/${v.eventContentId}"><i style="font-size: 25px; color: #161414" class="las la-pen-alt"></i></a>
                                            <a href='javascript: void(0)' onclick='student.delete("${v.eventContentId}")' title='削除'>
                                                <i style="font-size: 25px; color: red" class="las la-trash"></i>
                                            </a>
                                         </td>`;
                                break;
                            }
                    }

                } else if (rolesUser.includes("Doctor")) {
                    switch (v.statusId) {
                        case 2:
                            {
                                row = ` <td>
                                            <a href='javascript: void(0)' onclick='student.changeStatus("${v.eventContentId}", 3)' title='修了'>
                                                <i style="font-size: 18px; color:#00BFFF" class="fas fa-check"></i>
                                            </a>
                                         </td>`;
                                break;
                            }
                        case 3:
                            {
                                row = ` <td>
                                           <i style="font-size: 18px; color:#a3c2c2" class="fas fa-check"></i>
                                         </td>`;
                                break;
                            }
                        default:
                            {
                                row = ` <td>
                                         </td>`;
                                break;
                            }
                    }
                }
                $('#tbStudentDetails>tbody').append(
                    `<tr>
                        <td scope="row" style="font-size: 20px;">
                           ${v.courseName}
                        </td>
                        <td class="text-left"><label><i class="${v.eventIcon} mr-2"></i> ${v.eventName}</label></td>
                        <td class="text-center">
                            <a class="${(v.statusId == 1 ? "button5" : (v.statusId == 2 ? "button6" : "button4"))}">
                                ${v.statusName}
                            </a>
                         </td>
                        <td>
                            <a href="/eventcontent/update/${v.eventContentId}" class="notification">
                                <i style="font-size: 30px; color: #00BFFF" class="far fa-bell"></i>
                                ${v.countNotification == 0 ? "" : '<span class="badge">' + v.countNotification + '</span>'}
                            </a>
                        </td>
                        ${row}
                    </tr>`
                );
            });
            student.drawDataTable();
        }
    });
}

student.getSearchStatus = function () {
    var statuses = [];
    $.each($("input[name='statusEvent']:checked"), function () {
        statuses.push(parseInt($(this).val()));
    });
    return statuses;
}

student.initCourses = function () {
    $.ajax({
        url: `/course/gets/${studentId}`,
        method: 'GET',
        dataType: 'JSON',
        success: function (response) {
            $('#Course').empty();
            $('#Course').append(
                '<option selected value="">グレード</option>'
            );
            $.each(response.data, function (i, v) {
                $('#Course').append(
                    `<option value=${v.courseId}>${v.courseName}</option>`
                );
            });
        }
    });
}

student.initEvents = function () {
    $.ajax({
        url: `/event/gets`,
        method: 'GET',
        dataType: 'JSON',
        success: function (response) {
            $('#Event').empty();
            $('#Event').append(
                '<option selected value="">イベント</option>'
            );
            $.each(response.data, function (i, v) {
                $('#Event').append(
                    `<option value=${v.eventId}>${v.eventName}</option>`
                );
            });
        }
    });
}



student.drawDataTable = function () {
    tableStudentDetails = $('#tbStudentDetails').DataTable({
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
    tableStudentDetails.page(student.currentPage).draw(false);
};

student.getRoles = function () {
    $.ajax({
        url: '/account/getRolesUser',
        method: 'GET',
        dataType: 'JSON',
        success: function (response) {
            rolesUser = response.data.result;
            student.showData();
        }
    });
    return rolesUser;
}

student.init = function () {
    student.getRoles();
    student.initCourses();
    student.initEvents();
}

$(document).ready(function () {
    student.init();
});
