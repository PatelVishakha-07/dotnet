<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="tuple.aspx.cs" Inherits="registration.tuple" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Name: <asp:TextBox ID="txtname" runat="server"></asp:TextBox> <br /><br />
            Age:<asp:TextBox ID="txtage" runat="server"></asp:TextBox><br /><br />
            Course: <asp:TextBox ID="txtcourse" runat="server"></asp:TextBox><br /><br />

            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" /> <br /><br />

            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
