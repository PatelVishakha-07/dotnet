<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="images.aspx.cs" Inherits="registration.images" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="Image1" ImageUrl="~/images/mahi_rutu.jpg" Height="500" Width="500" runat="server" />
            <br /><br /><br />

            <asp:ImageButton ID="imgbtn" ImageUrl="~/images/mahi1.jpg" Height="200" Width="200" runat="server" OnClick="imgbtn_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblimg" runat="server" Text=""></asp:Label>
            <br /><br /><br /><br />


            <asp:BulletedList ID="bldlst" BulletStyle="UpperAlpha" runat="server">
                <asp:ListItem Text="MCA" Value="MCA"></asp:ListItem>
                <asp:ListItem Text="BCA" Value="BCA"></asp:ListItem>
                <asp:ListItem Text="BBA" Value="BBA"></asp:ListItem>
            </asp:BulletedList>

            <br /><br /><br />

            <asp:HyperLink ID="HyperLink1" NavigateUrl="https://leetcode.com/u/patelvishakha-tech/" Target="_blank" runat="server">Leetcode</asp:HyperLink>
        </div>
    </form>
</body>
</html>
