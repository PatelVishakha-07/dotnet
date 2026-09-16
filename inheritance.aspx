<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="inheritance.aspx.cs" Inherits="registration.inheritance" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Length: <asp:TextBox ID="txtlength" runat="server" TextMode="Number"></asp:TextBox> <br /><br />
            Width: <asp:TextBox ID="txtwidth" runat="server" TextMode="Number"></asp:TextBox> <br /><br />
            Radius: <asp:TextBox ID="txtrad" runat="server" TextMode="Number"></asp:TextBox> <br /><br />

            <asp:Button ID="btndisplay" runat="server" Text="Display" OnClick="btndisplay_Click" /> <br /><br />

            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
