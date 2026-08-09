<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="registration.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter string: <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox> <br /> <br />

            Enter N1: <asp:TextBox ID="txtn1" runat="server"></asp:TextBox> <br /> <br />

            Enter N2: <asp:TextBox ID="txtn2" runat="server"></asp:TextBox> <br /> <br />

            <asp:Label ID="Label1" runat="server" Text=""></asp:Label><br /> <br />
            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
