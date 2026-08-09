<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="listbox.aspx.cs" Inherits="registration.listbox" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lst1" SelectionMode="Multiple" runat="server" style="z-index: 1; left: 99px; top: 82px; position: absolute; height: 162px; width: 142px">
                <asp:ListItem Text="MCA" Value="MCA"></asp:ListItem>
                <asp:ListItem Text="BCA" Value="BCA"></asp:ListItem>
                <asp:ListItem Text="MBA" Value="MBA"></asp:ListItem>
                <asp:ListItem Text="BBA" Value="BBA"></asp:ListItem>
            </asp:ListBox>

            <asp:Button ID="btnright" runat="server" Text=">" style="z-index: 1; left: 375px; top: 72px; position: absolute; height: 30px; width: 94px; bottom: 713px;" OnClick="btnright_Click" />
            <asp:Button ID="btnleft" runat="server" Text="<" style="z-index: 1; left: 378px; top: 122px; position: absolute; height: 34px; width: 96px" OnClick="btnleft_Click" />
            <asp:Button ID="btnrightall" runat="server" Text=">>" style="z-index: 1; left: 378px; top: 176px; position: absolute; height: 35px; width: 94px" OnClick="btnrightall_Click" />
            <asp:Button ID="btnleftall" runat="server" Text="<<" style="z-index: 1; left: 382px; top: 237px; position: absolute; height: 37px; width: 87px" OnClick="btnleftall_Click" />
        </div>
        <asp:ListBox ID="lst2" SelectionMode="Multiple" runat="server" style="z-index: 1; left: 659px; top: 83px; position: absolute; height: 167px; width: 166px">
            <asp:ListItem Text="BSCIT" Value="BSCIT"></asp:ListItem>
            <asp:ListItem Text="MSCIT" Value="MSCIT"></asp:ListItem>
            <asp:ListItem Text="BCOM" Value="BCOM"></asp:ListItem>
            <asp:ListItem Text="MCOM" Value="MCOM"></asp:ListItem>
        </asp:ListBox>

        <br /><br />
        <br />
        <asp:Label ID="lblmsg" runat="server" Text="" style="z-index: 1; left: 101px; top: 311px; position: absolute; height: 35px; width: 219px"></asp:Label>

        <br /><br /><br /><br /><br /><br />

        <asp:Label ID="Label1" runat="server" Text="Search Course:" style="z-index: 1; left: 97px; top: 440px; position: absolute"></asp:Label>
        <asp:TextBox ID="txtsearch" runat="server" style="z-index: 1; left: 259px; top: 431px; position: absolute; width: 223px"></asp:TextBox> <br /><br />
        <asp:Button ID="btnsearch" runat="server" Text="Search" OnClick="btnsearch_Click" style="z-index: 1; left: 99px; top: 523px; position: absolute; height: 30px; width: 106px" /> <br /><br />
        <asp:Label ID="lblsearch" runat="server" Text="" style="z-index: 1; left: 552px; top: 430px; position: absolute; width: 173px; height: 25px"></asp:Label>
    </form>
</body>
</html>
