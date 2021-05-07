var chart = {} || chart;
var studentId = $('#studentId').val();
var c1 = [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0];
var c2 = [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0];
var c3 = [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0];
var c4 = [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0];
var c5 = [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0];
var c6 = [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0];
var c7 = [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0];
var c8 = [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0];
var c9 = [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0];
var c10 = [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0];
var c11 = [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0];
var c12 = [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0];
chart.trackingChart = function () {
    var studentId = $('#studentId').val();
    $.ajax({
        url: `/Tracking/TrackingChart/${studentId}`,
        method: 'GET',
        dataType: 'JSON',
        contentType: 'application/json',
        success: function (reponse) {
            var ability = ['主体性', '働きかけ力', '実行力', '課題発見力', '計画力', '創造力',
                '発信力', '傾聴力', '柔軟性', '状況把握力', '規律性', 'ストレスコントロール力'];
            reponse.data.forEach((item) => {
                switch (item.courseName) {
                    case "小1":
                        c1[item.abilityId - 1] = item.count;
                        break;
                    case "小2":
                        c2[item.abilityId - 1] = item.count;
                        break;
                    case "小3":
                        c3[item.abilityId - 1] = item.count;
                        break;
                    case "小4":
                        c4[item.abilityId - 1] = item.count;
                        break;
                    case "小5":
                        c5[item.abilityId - 1] = item.count;
                        break;
                    case "中１":
                        c6[item.abilityId - 1] = item.count;
                        break;
                    case "中２":
                        c7[item.abilityId - 1] = item.count;
                        break;
                    case "中３":
                        c8[item.abilityId - 1] = item.count;
                        break;
                    case "中４":
                        c9[item.abilityId - 1] = item.count;
                        break;
                    case "高1":
                        c10[item.abilityId - 1] = item.count;
                        break;
                    case "高２":
                        c11[item.abilityId - 1] = item.count;
                        break;
                    case "高３":
                        c12[item.abilityId - 1] = item.count;
                        break;
                }
            });
            var chartData = {
                type: 'bar',
                data: {
                    labels: ['小1', '小2', '小3', '小4', '小5', '中１', '中２', '中３', '中４', '高1', '高２', '高３'],
                    hoverOffset: 4,
                    datasets: [{
                        label: ability[0],
                        data: [c1[0], c2[0], c3[0], c4[0], c5[0], c6[0], c7[0], c8[0], c9[0], c10[0], c11[0], c12[0]],
                        backgroundColor: '#3a2d38',

                    }, {
                        label: ability[1],
                        data: [c1[1], c2[1], c3[1], c4[1], c5[1], c6[1], c7[1], c8[1], c9[1], c10[1], c11[1], c12[1]],
                        backgroundColor: '#1d545b',

                    }, {
                        label: ability[2],
                        data: [c1[2], c2[2], c3[2], c4[2], c5[2], c6[2], c7[2], c8[2], c9[2], c10[2], c11[2], c12[2]],
                        backgroundColor: '#f4d8cd',

                    }, {
                        label: ability[3],
                        data: [c1[3], c2[3], c3[3], c4[3], c5[3], c6[3], c7[3], c8[3], c9[3], c10[3], c11[3], c12[3]],
                        backgroundColor: '#f78c3a',

                    }, {
                        label: ability[4],
                        data: [c1[4], c2[4], c3[4], c4[4], c5[4], c6[4], c7[4], c8[4], c9[4], c10[4], c11[4], c12[4]],
                        backgroundColor: '#d62f0a',

                    }, {
                        label: ability[5],
                        data: [c1[5], c2[5], c3[5], c4[5], c5[5], c6[5], c7[5], c8[5], c9[5], c10[5], c11[5], c12[5]],
                        backgroundColor: '#efa101',

                    }, {
                        label: ability[6],
                        data: [c1[6], c2[6], c3[6], c4[6], c5[6], c6[6], c7[6], c8[6], c9[6], c10[6], c11[6], c12[6]],
                        backgroundColor: '#5db1bf',

                    }, {
                        label: ability[7],
                        data: [c1[7], c2[7], c3[7], c4[7], c5[7], c6[7], c7[7], c8[7], c9[7], c10[7], c11[7], c12[7]],
                        backgroundColor: '#662d9a',

                    }, {
                        label: ability[8],
                        data: [c1[8], c2[8], c3[8], c4[8], c5[8], c6[8], c7[8], c8[8], c9[8], c10[8], c11[8], c12[8]],
                        backgroundColor: '#2a9034',

                    }, {
                        label: ability[9],
                        data: [c1[9], c2[9], c3[9], c4[9], c5[9], c6[9], c7[9], c8[9], c9[9], c10[9], c11[9], c12[9]],
                        backgroundColor: '#efaac3',

                    }, {
                        label: ability[10],
                        data: [c1[10], c2[10], c3[10], c4[10], c5[10], c6[10], c7[10], c8[10], c9[10], c10[10], c11[10], c12[10]],
                        backgroundColor: '#a33972',

                    }, {
                        label: ability[11],
                        data: [c1[11], c2[11], c3[11], c4[11], c5[11], c6[11], c7[11], c8[11], c9[11], c10[11], c11[11], c12[11]],
                        backgroundColor: '#7291b6',

                    }]
                },
                options: {
                    maintainAspectRatio: false,
                    responsive: true,
                    plugins: {
                        labels: {
                            render: () => { }
                        }
                    },

                    legend: {
                        display: false
                    },
                    scales: {
                        xAxes: [{
                            stacked: true
                        }],
                        yAxes: [{
                            stacked: true
                        }]
                    },
                }

            };
            var canvas = document.getElementById('barChart');
            var myChart = new Chart(canvas, chartData);
            canvas.onclick = function (evt) {
                var activePoint = myChart.getElementAtEvent(evt)[0];
                var courseName = activePoint._model.label;
                var data = activePoint._chart.data;
                var datasetIndex = activePoint._datasetIndex;
                var abilytiName = data.datasets[datasetIndex].label;
                $.ajax({
                    url: `/Tracking/ShowEventChartBar/${studentId}/${abilytiName}/${courseName}`,
                    method: 'GET',
                    dataType: 'JSON',
                    contentType: 'application/json',
                    success: function (reponse) {
                        $('#eventTable2>tBody').empty();
                        reponse.data.forEach((item) => {
                            $('#eventTable2>tBody').append(
                                `<tr onclick="dbclick(${item.eventContentId})">
                                        <td>${item.eventContentId}</td>
                                        <td>${item.eventName}</td>
                                </tr>`
                            );
                        });
                    }
                });
                $('#exampleModalLong2').modal('show');
            };
            chart.dougnutChart();
        }
    });
}

chart.dougnutChart = function () {
    var studentId = $('#studentId').val();

    $.ajax({
        url: `/Tracking/TrackingDoughnutByStudentId/${studentId}`,
        method: 'GET',
        dataType: 'JSON',
        contentType: 'application/json',
        success: function (reponse) {

            var ability = [];
            var countAbility = [];
            var colorAbility = [];
            reponse.data.forEach((item) => {
                ability.push(item.abilityName);
                countAbility.push(item.count);
                colorAbility.push(item.color);
            });
            const data = {
                labels: ability,
                datasets: [{
                    label: 'Chart Doughnut',
                    data: countAbility,
                    backgroundColor: colorAbility
                }],

            };
            var sum = countAbility.reduce(function (a, b) { return a + b; }, 0);
            $('#TotalAb').append("" + sum + "");
            var canvas = document.getElementById('doughnutChart');
            var myNewChart = new Chart(canvas, {
                type: "doughnut",
                data,
                options: {
                    maintainAspectRatio: false,
                    responsive: true,
                    plugins: {
                        labels: {
                            render: 'value',
                            fontColor: '#ffff',
                            precision: 2
                        }
                    },
                    legend: {
                        display: false
                    },
                }
            });
            canvas.onclick = function (evt) {
                var activePoints = myNewChart.getElementsAtEvent(evt);
                if (activePoints[0]) {
                    var chartData = activePoints[0]['_chart'].config.data;
                    var idx = activePoints[0]['_index'];
                    var abilytiName = chartData.labels[idx];
                    $.ajax({
                        url: `/Tracking/ShowEventChartDoughnut/${studentId}/${abilytiName}`,
                        method: 'GET',
                        dataType: 'JSON',
                        contentType: 'application/json',
                        success: function (reponse) {
                            $('#eventTable>tBody').empty();
                            reponse.data.forEach((item) => {
                                $('#eventTable>tBody').append(
                                    `<tr onclick="dbclick(${item.eventContentId})">
                                        <td>${item.eventContentId}</td>
                                        <td>${item.eventName}</td>
                                    </tr>`
                                );
                            });
                        }
                    });
                    $('#exampleModalLong').modal('show');
                }
            };
            chart.loadAbilities();

        }
    });
}
chart.loadAbilities = function () {
    $.ajax({
        url: `/Tracking/ShowAbility`,
        method: 'GET',
        dataType: 'JSON',
        contentType: 'application/json',
        success: function (reponse) {
            var ability = [];
            var colorAbility = [];
            reponse.data.forEach((item) => {
                ability.push(item.abilityName);
                colorAbility.push(item.color);

            });
            $('#ab1').append("<td><p class='item-list'  style='background: " + colorAbility[0] + ";'></p></td>");
            $('#ab1').append("<td class=\"event\"><p>" + ability[0] + "</></td>");
            $('#ab1').append("<td ><p class='item-list' style='background:  " + colorAbility[1] + ";'></p></td>");
            $('#ab1').append("<td'><p>" + ability[1] + "</p></td>");
            $('#ab2').append("<td><p class='item-list' style='background:  " + colorAbility[2] + ";'></p></td>");
            $('#ab2').append("<td><p>" + ability[2] + "</p></td>");
            $('#ab2').append("<td><p  class='item-list' style='background: " + colorAbility[3] + ";'></p></td>");
            $('#ab2').append("<td'><p>" + ability[3] + "</p></td>");
            $('#ab3').append("<td><p class='item-list'style='background: " + colorAbility[4] + ";'></p></td>");
            $('#ab3').append("<td><p>" + ability[4] + "</p></td>");
            $('#ab3').append("<td><p  class='item-list' style='background: " + colorAbility[5] + ";'></p></td>");
            $('#ab3').append("<td'><p>" + ability[5] + "</p></td>");
            $('#ab4').append("<td><p class='item-list' style='background: " + colorAbility[6] + ";'></p></td>");
            $('#ab4').append("<td><p>" + ability[6] + "</p></td>");
            $('#ab4').append("<td><p  class='item-list'style='background: " + colorAbility[7] + ";'></p></td>");
            $('#ab4').append("<td'><p>" + ability[7] + "</p></td>");
            $('#ab5').append("<td><p class='item-list'style='background: " + colorAbility[8] + ";'></p></td>");
            $('#ab5').append("<td><p>" + ability[8] + "</p></td>");
            $('#ab5').append("<td><p  class='item-list' style='background: " + colorAbility[9] + ";'></p></td>");
            $('#ab5').append("<td'><p>" + ability[9] + "</p></td>");
            $('#ab6').append("<td><p class='item-list'style='background: " + colorAbility[10] + ";'></p></td>");
            $('#ab6').append("<td><p>" + ability[10] + "</p></td>");
            $('#ab6').append("<td><p  class='item-list' style='background: " + colorAbility[11] + ";'></p></td>");
            $('#ab6').append("<td'><p>" + ability[11] + "</p></td>");
            chart.studentInfo();
        }
    });
}

$('#charttotable').change(function () {
    if (document.getElementById("charttotable").checked) {
        document.getElementById("abtable").classList.remove('d-none');
        document.getElementById("abtable").classList.add('d-block');
        document.getElementById("abchart").classList.remove('d-block');
        document.getElementById("abchart").classList.add('d-none');

    }
    else {
        document.getElementById("abtable").classList.remove('d-block');
        document.getElementById("abtable").classList.add('d-none');
        document.getElementById("abchart").classList.remove('d-none');
        document.getElementById("abchart").classList.add('d-block');

    }

});
chart.studentInfo = function () {
    var studentId = $('#studentId').val();
    $.ajax({
        url: `/Tracking/StudentInfo/${studentId}`,
        method: 'GET',
        dataType: 'JSON',
        contentType: 'application/json',
        success: function (reponse) {
            console.log(reponse);
            $('#cardStudent').append(
                `<div class="chart-profile">
                    <div style="border-top: 3px solid #777676; ">                       
                        <strong>学生のコード: </strong>${reponse.data.studentCode} </br>
                        <strong>学生の名前: </strong>${reponse.data.fullName} </br>
                        <strong>クラス: </strong>${reponse.data.courseCurrentName}

                    </div>
                </div>
                <div class=" chart-profile" >
                    <img src="/img/${reponse.data.avatarName}" class="chart-avata" />
                    </div>`
            );
            chart.trackingTable();
        }
    });
}
chart.trackingTable = function () {
    var body = $('body')[0];
    $.ajax({
        url: `/Tracking/ShowAbility`,
        method: 'GET',
        dataType: 'JSON',
        contentType: 'application/json',
        success: function (reponse) {
            var chartValue = new Array(15);
            $.each(reponse.data, function (index, value) {
                chartValue[index] = new Array(14);
                chartValue[index][0] = value.color;
                chartValue[index][1] = value.abilityName;
                chartValue[index][2] = c1[index] == 0 ? "-" : c1[index];
                chartValue[index][3] = c2[index] == 0 ? "-" : c2[index];
                chartValue[index][4] = c3[index] == 0 ? "-" : c3[index];
                chartValue[index][5] = c4[index] == 0 ? "-" : c4[index];
                chartValue[index][6] = c5[index] == 0 ? "-" : c5[index];
                chartValue[index][7] = c6[index] == 0 ? "-" : c6[index];
                chartValue[index][8] = c7[index] == 0 ? "-" : c7[index];
                chartValue[index][9] = c8[index] == 0 ? "-" : c8[index];
                chartValue[index][10] = c9[index] == 0 ? "-" : c9[index];
                chartValue[index][11] = c10[index] == 0 ? "-" : c10[index];
                chartValue[index][12] = c11[index] == 0 ? "-" : c11[index];
                chartValue[index][13] = c12[index] == 0 ? "-" : c12[index];

            });
            $('#trackingTable1').hide();
            $('#trackingTable2').hide();
            $.each(reponse.data, function (index, value) {

                $('#trackingTable>tbody').append(`
                            <tr>
                                <th style="color: ${chartValue[index][0]}">${chartValue[index][1]}</th>
                                <td class="text-center">${chartValue[index][2]}</td>
                                <td class="text-center">${chartValue[index][3]}</td>
                                <td class="text-center">${chartValue[index][4]}</td>
                                <td class="text-center">${chartValue[index][5]}</td>
                                <td class="text-center">${chartValue[index][6]}</td>
                                <td class="text-center">${chartValue[index][7]}</td>                               
                                <td class="text-center">${chartValue[index][8]}</td>
                                <td class="text-center">${chartValue[index][9]}</td>
                                <td class="text-center">${chartValue[index][10]}</td>
                                <td class="text-center">${chartValue[index][11]}</td>
                                <td class="text-center">${chartValue[index][12]}</td>
                                <td class="text-center">${chartValue[index][13]}</td>
                            </tr>
                        `);
            });
            body.onresize = function () {
                var width = $(window).width();
                console.log(width)
                if (width >= 736) {
                    $('.card-body').removeClass('chard-height');
                    $('#trackingTable').show();
                    $('#trackingTable1').hide();
                    $('#trackingTable2').hide();
                    $('#trackingTable>tbody').empty();
                    $.each(reponse.data, function (index, value) {

                        $('#trackingTable>tbody').append(`
                    <tr>
                                <th style="color: ${chartValue[index][0] = value.color}">${chartValue[index][1]}</th>
                                <td class="text-center">${chartValue[index][2]}</td>
                                <td class="text-center">${chartValue[index][3]}</td>
                                <td class="text-center">${chartValue[index][4]}</td>
                                <td class="text-center">${chartValue[index][5]}</td>
                                <td class="text-center">${chartValue[index][6]}</td>
                                <td class="text-center">${chartValue[index][7]}</td>                               
                                <td class="text-center">${chartValue[index][8]}</td>
                                <td class="text-center">${chartValue[index][9]}</td>
                                <td class="text-center">${chartValue[index][10]}</td>
                                <td class="text-center">${chartValue[index][11]}</td>
                                <td class="text-center">${chartValue[index][12]}</td>
                                <td class="text-center">${chartValue[index][13]}</td>
                            </tr>
                        `);
                    });
                }

                if (width < 736) {
                    var a = $('.card-body')[3];
                    a.classList.add('chard-height');
                    $('#trackingTable').hide();
                    $('#trackingTable1').show();
                    $('#trackingTable2').show();
                    $('#trackingTable1>tbody').empty();
                    $('#trackingTable2>tbody').empty();
                    $.each(reponse.data, function (index, value) {
                        $('#trackingTable1>tbody').append(`
                        <tr>
                            <th style="color: ${value.color}">${value.abilityName}</th>
                            <td class="text-center">${chartValue[index][2]}</td>
                            <td class="text-center">${chartValue[index][3]}</td>
                            <td class="text-center">${chartValue[index][4]}</td>
                            <td class="text-center">${chartValue[index][5]}</td>
                            <td class="text-center">${chartValue[index][6]}</td>
                            <td class="text-center">${chartValue[index][7]}</td>
                        
                        </tr>
                    `);
                        $('#trackingTable2>tbody').append(`
                            <tr>
                        <th style="color: ${value.color}">${value.abilityName}</th>
                                <td class="text-center">${chartValue[index][8]}</td>
                                <td class="text-center">${chartValue[index][9]}</td>
                                <td class="text-center">${chartValue[index][10]}</td>
                                <td class="text-center">${chartValue[index][11]}</td>
                                <td class="text-center">${chartValue[index][12]}</td>
                                <td class="text-center">${chartValue[index][13]}</td>
                        
                    </tr>
                `);
                    })
                }
            }

        }
    });
}
document.querySelector('.switch').onclick = function () {
    var width = $(window).width();
    var check = document.getElementById("charttotable").checked;
    console.log(check);
    var a = $('.card-body')[3];
    if (check == false && width < 736) {
        a.classList.remove('chard-height');
    }
    else if (check == true && width < 736) {
        a.classList.add('chard-height');
    }
}

function dbclick(eventcontentId) {
    window.location.href = '/EventContent/Update/' + eventcontentId;
}
$(document).ready(function () {
    chart.trackingChart();
})
