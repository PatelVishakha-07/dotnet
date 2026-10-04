<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="linq.aspx.cs" Inherits="registration.linq" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            Emp Id: <asp:TextBox ID="txtempid" runat="server"></asp:TextBox> <br /><br />

            Emp Name: <asp:TextBox ID="txtname" runat="server"></asp:TextBox> <br /><br />

            Salary: <asp:TextBox ID="txtsal" runat="server"></asp:TextBox> <br /><br />

            Dept Id: <asp:TextBox ID="txtdptid" runat="server"></asp:TextBox> <br /><br />

            <asp:Button ID="Button1" runat="server" Text="Add" OnClick="Button1_Click" /> <br /><br />

            <asp:Button ID="btndisplay" runat="server" Text="Display" OnClick="btndisplay_Click" /> <br /><br />

            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
