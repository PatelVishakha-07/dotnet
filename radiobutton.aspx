<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="radiobutton.aspx.cs" Inherits="registration.radiobutton" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter String: <asp:TextBox ID="txtstr" runat="server"></asp:TextBox> <br /><br /><br />

            <asp:RadioButtonList ID="RadioButtonList1" AutoPostBack="true" runat="server" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
                <asp:ListItem Text="UpperCase" Value="UpperCase"></asp:ListItem>
                <asp:ListItem Text="LowerCase" Value="LowerCase"></asp:ListItem>
                <asp:ListItem Text="First 3 Char" Value="First 3 Char"></asp:ListItem>
                <asp:ListItem Text="Last 3 Char" Value="Last 3 Char"></asp:ListItem>
            </asp:RadioButtonList>

            <br /><br />
            Output:  <asp:TextBox ID="txtoutput" ReadOnly="true" runat="server"></asp:TextBox>
        </div>
    </form>
</body>
</html>
