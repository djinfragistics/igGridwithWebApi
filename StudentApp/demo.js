$(function () {

    //var data = [
    //              { "Name": "John Smith", "Age": 45 },
    //              { "Name": "Mary Johnson", "Age": 32 },
    //              { "Name": "Bob Ferguson", "Age": 27 }
    //];
    alert("hey");
    $("#grid").igGrid({
        dataSource: "http://localhost:39731/api/students" //JSON Array defined above                     
    });
});