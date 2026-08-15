<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="image_next.aspx.cs" Inherits="registration.image_next" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="img" runat="server" style="position: relative; top: 35px; left: 229px; height: 209px; width: 230px" /> <br /> <br />            

            <asp:Button ID="btnprev" runat="server" Text="Previous" style="position: relative; top: 177px; left: 147px" OnClick="btnprev_Click" />

            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

            <asp:Button ID="btnnext" runat="server" Text="Next" style="position: relative; top: 177px; left: 100px; width: 68px" OnClick="btnnext_Click" />
       
        </div>
        <p style="margin-left: 320px">
            <asp:Label ID="lbldata" runat="server" style="position: relative" Text=""></asp:Label>
        </p>
    </form>
</body>
</html>
