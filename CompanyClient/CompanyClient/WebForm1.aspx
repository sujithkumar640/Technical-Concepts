<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CompanyClient.WebForm1" %>

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
            <td>
                <asp:Button ID="Button1" runat="server" Text="Get Public Info" OnClick="Button1_Click" />

            </td>
            <td>
                <asp:Label ID="Label1" runat="server" Font-Bold="true"></asp:Label>

            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="Button2" runat="server" Text="Get Confidential Info" OnClick="Button2_Click" />
            </td>
            <td>
                <asp:Label ID="Label2" runat="server" Font-Bold="true"></asp:Label>
            </td>
        </tr>
    </table>
    </div>
    </form>
</body>
</html>
