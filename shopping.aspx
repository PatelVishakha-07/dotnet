<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="shopping.aspx.cs" Inherits="registration.shopping" %>

<!DOCTYPE html>
<script runat="server">

    protected void btn1_Click(object sender, EventArgs e)
    {

    }
</script>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="img1" AlternateText="img1" ImageUrl="~/images/mahi1.jpg" Height="165px" Width="148px" runat="server" style="position: relative; top: 4px; left: 125px" />

            <asp:Image ID="Image1" ImageUrl="~/images/mahi1.jpg" runat="server" style="position: relative; top: 391px; left: 275px; height: 159px; width: 192px;" />

            <asp:Image ID="Image2" ImageUrl="~/images/mahi1.jpg" runat="server" style="position: relative; top: 9px; left: 116px; height: 165px; width: 169px;" />

            <asp:Image ID="Image3" ImageUrl="~/images/mahi1.jpg" runat="server" style="position: relative; top: 15px; left: 247px; height: 167px; width: 184px;" />

            <asp:Image ID="Image4" ImageUrl="~/images/mahi1.jpg" runat="server" style="position: relative; top: 386px; left: -584px; height: 162px; width: 179px;" />
        </div>
        <asp:Button ID="btn1" runat="server" style="position: relative; top: 144px; left: 131px" Text="Add to Cart" OnClick="btn1_Click" />
        <asp:DropDownList ID="DropDownList1" runat="server" style="position: relative; top: 65px; left: 26px">
        </asp:DropDownList>
        <asp:DropDownList ID="DropDownList2" runat="server" style="position: relative; top: 70px; left: 255px">
        </asp:DropDownList>
        <asp:DropDownList ID="DropDownList3" runat="server" style="position: relative; top: 71px; left: 498px">
        </asp:DropDownList>
        <p>
        <asp:Button ID="btn2" runat="server" style="position: relative; top: 99px; left: 467px" Text="Add to Cart" OnClick="btn1_Click" />
        <asp:Button ID="btn3" runat="server" style="position: relative; top: 100px; left: 670px" Text="Add to Cart" OnClick="btn1_Click" />
        </p>
        <p>
        <asp:Button ID="btn4" runat="server" style="position: relative; top: 508px; left: 125px" Text="Add to Cart" OnClick="btn1_Click" />
        <asp:Button ID="btn5" runat="server" style="position: relative; top: 511px; left: 328px" Text="Add to Cart" OnClick="btn1_Click" />
        </p>
    </form>
</body>
</html>
