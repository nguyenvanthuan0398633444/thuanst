
var book = {} || book;

book.mentions= function() {
  // $("#html-simple").dxHtmlEditor({
  //   height: 300,
  //   mentions: [
  //     {
  //       dataSource: employees,
  //       marker: "@"
  //     },
  //     {
  //       dataSource: employees.name2,
  //       itemTemplate: function(item) {
  //         console.log(item,'a');
  //         return (         
  //           `'<div>          
  //           <strong style="color: ${item.color}">${item.name2}</strong></div>'`
  //         );
  //       },
  //       marker: "#"
  //     }
  //   ],
  //   toolbar: {
  //     items: toolbarItems
  //   }
  // });

  var itemTemplate = function(item) {
    return (
      `<strong style="color: ${item.color}">${item.name2}</strong>`
    );
  };

  $("#html-objects").dxHtmlEditor({
    
    height: 300,
    mentions: [
      {
        dataSource: employees,
        marker: "#",
        valueExpr: "name2",
        searchExpr: ["name2","color"],
        itemTemplate: itemTemplate,
        displayExpr: itemTemplate
      }
    ],
   
  });
};

book.mentions2 = function() {
  $('#mentionx').mentiony({
    onDataRequest: function (mode, keyword, onDataRequestCompleteCallback) {

        $.ajax({
            method: "GET",
            url: "https://localhost:44343/Ability/gets",
            dataType: "json",
            success: function (response) {
               
                var data = response;
                console.log(data[0].bookName, 'a')
                for(var i = 0; i < data.length; i++) {
                    data[i].name = data[i].abilityName;
                    data[i].id = data[i].abilityId;
                    data[i].color = data[i].color;
                }
                // NOTE: Assuming this filter process was done on server-side
                data = jQuery.grep(data, function( item ) {
                    return item.name.toLowerCase().indexOf(keyword.toLowerCase()) > -1;
                });
                // End server-side

               

                // Call this to populate mention.
                onDataRequestCompleteCallback.call(this, data);
            }
        });

    },
    timeOut: 500, // Timeout to show mention after press @
    debug: 1, // show debug info
});
}

var employees = [{ 
    name2: "John Heart",
    team: "Engineering",
    icon: "images/mentions/John-Heart.png",
    color: "Red"
}, {
    name2: "Kevin Carter",
    team: "Engineering",
    icon: "images/mentions/Kevin-Carter.png",
    color: "yellow"
    
}, {
    name2: "Olivia Peyton",
    team: "Management",
    icon: "images/mentions/Olivia-Peyton.png",
    color: "blue"
}, {
    name2: "Robert Reagan",
    team: "Management",
    icon: "images/mentions/Robert-Reagan.png",
    color: "violet"
}, {
    name2: "Cynthia Stanwick",
    team: "Engineering",
    icon: "images/mentions/Cynthia-Stanwick.png",
    color: "green"
}, {
    name2: "Brett Wade ",
    team: "Analysis",
    icon: "images/mentions/Brett-Wade.png",
    color: "pink"
}, {
    name2: "Greta Sims",
    team: "QA",
    icon: "images/mentions/Greta-Sims.png",
    color: "brown"
}];

book.init = function () {
  $('#mycomment').emojioneArea();
  //book.mentions2();
}
$(document).ready(function () {
  book.init();
});