<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Student.aspx.cs" Inherits="CalcWebServiceClientApp.Student" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
   
</head>
<body>
    <form id="form1" runat="server">
      
    <div>
        <table>
            <tr>
                <td>ID</td>
                <td>
                    <asp:TextBox ID="txtStudentId" runat="server"></asp:TextBox>
                    <input type="button" id="btnStudent" value="Get Student" onclick="GetStudentById()" />
                </td>
            </tr>
            <tr>
                <td>Name</td>
                <td>
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Gender</td>
                <td>
                    <asp:TextBox ID="txtGender" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Total Marks</td>
                <td>
                    <asp:TextBox ID="txtTotalMarks" runat="server"></asp:TextBox>
                </td>
            </tr>

        </table>
    </div>
    </form>
    <script src="http://code.jquery.com/jquery-1.9.1.min.js"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            var surl = "http://localhost:56771/StudentWebService.asmx/GetStudentById";
            $.ajax({
                type: 'POST',
                url: surl,
                crossDomain: true,
                contentType: "application/json; charset=utf-8",
                data: JSON.stringify({ 'ID': 1}),
                dataType: "json",
                success: function (msg) {
                    $.each(msg, function (name, value) {
                        document.getElementById("txtStudentId").value = value.ID;
                        document.getElementById("txtName").value = value.Name;
                        document.getElementById("txtGender").value = value.Gender;
                        document.getElementById("txtTotalMarks").value = value.TotalMarks;
                    });
                },
                error: function (xhr, status, error) { alert('Error'); },
                async: false,
                cache: false
            });
        });

        /* $(document).ready(function () {
            $("#btnStudent").click(function () {
                //lert(1);
                $.ajax({
                    type: "POST",
                    url: "http://localhost:56771/StudentWebService.asmx/GetDateTime",
                    data: "{}",
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    success: function (msg) {
                        alert(msg.d);
                    }
                });

            });
        });*/
        function GetStudentById() {
            var id = document.getElementById("txtStudentId").value;
            var surl = "http://localhost:56771/StudentWebService.asmx/GetStudentById";
            $.ajax({
                type: 'POST',
                url: surl,
                crossDomain: true,
                contentType: "application/json; charset=utf-8",
                data: JSON.stringify({ 'ID': id }),
                dataType: "json",
                success: function (msg) {
                    $.each(msg, function (name, value) {
                        document.getElementById("txtName").value = value.Name;
                        document.getElementById("txtGender").value = value.Gender;
                        document.getElementById("txtTotalMarks").value = value.TotalMarks;
                    });
                },
                error: function (xhr, status, error) { alert('Error'); },
                async: false,
                cache: false
            });
        }
        /* function GetStudentById() {
             var id = document.getElementById("txtStudentId").value;
             Webservice.StudentWebService.GetStudentById(id, Success, ErrorMsg);
         }
         function Success(result) {
             document.getElementById("txtName").value = result["Name"];
             document.getElementById("txtGender").value = result["Gender"];
             document.getElementById("txtTotalMarks").value = result["TotalMarks"];
         }
         function ErrorMsg(errors) {
             alert(errors.get_message());
         }*/

    </script>
</body>
</html>
