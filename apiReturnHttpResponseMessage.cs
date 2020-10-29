$.ajax({
   url: "http://localhost:9948/api/TollsApi/GetSupplier",
   type: "Post",
   datatype: "json",
   data: JSON.stringify(dtl),
   contentType: "application/json; charset=utf-8",
   success: function (data) {
       debugger
       var tmpTable = "";
       $('#APITesting-d-dtl').empty();
       if (data.length > 0) {
           for (key in data) {
               tmp = data[key];
               var tmp = data[key];
               tmpTable += '<tr>'
               tmpTable += '<td>' + tmp.CardCode + '</td>'
               tmpTable += '<td>' + tmp.CardName + '</td>'
               tmpTable += '</tr>'
           }
           $('#APITesting-d-dtl').append(tmpTable);
       }
   }, error: function (xhr,status) {
       // return http response message
       alert(xhr.responseText);
       alert(xhr.statusCode);
       alert(xhr.statusText);
   }
});
