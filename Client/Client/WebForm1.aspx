<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Client.WebForm1" %>

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
            <td>Id</td>
            <td>
                <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
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
            <td>Date Of Birth</td>
            <td>
                <asp:TextBox ID="txtDateOfBirth" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Employe Type</td>
            <td>
                <asp:DropDownList ID="ddlEmployeeType" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlEmployeeType_SelectedIndexChanged">
                    <asp:ListItem Text="Select Employee Type" Value="-1"></asp:ListItem>
                    <asp:ListItem Text="Full Time Employee" Value="1"></asp:ListItem>
                    <asp:ListItem Text="Part Time Employee" Value="2"></asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr id="trAnnualSalary" runat="server" visible="false">
            <td>Annual Salary</td>
            <td>
                <asp:TextBox ID="txtAnnualSalary" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr id="trHourlyPay" runat="server" visible="false">
            <td>Hourly Pay</td>
            <td>
                <asp:TextBox ID="txtHourlyPay" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr id="trHoursWorked" runat="server" visible="false">
            <td>Hours Worked</td>
            <td>
                <asp:TextBox ID="txtHoursWorked" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnGetEmployee" runat="server" Text="Get Employee" OnClick="btnGetEmployee_Click" />

            </td>
            <td>
                <asp:Button ID="btnSave" runat="server" Text="Save Employee" OnClick="btnSave_Click" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblMessage" runat="server" Font-Bold="true"></asp:Label>

            </td>
            <td>
            </td>
        </tr>
    </table>
    </div>
    </form>
</body>
</html>
