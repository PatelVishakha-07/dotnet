<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="custom_validation.aspx.cs" Inherits="registration.custom_validation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter input: <asp:TextBox ID="txtinput" runat="server" ></asp:TextBox>


            <asp:CustomValidator
                ID="CustomValidator1" runat="server"
                ControlToValidate="txtinput" ForeColor="Red" Display="Dynamic"
                ErrorMessage="password should contain 1 uppercase, 1 lowercase, 1 digit, 1 special character and no space"
                OnServerValidate="CustomValidator1_ServerValidate"></asp:CustomValidator>
            <br /><br />
            
            <asp:Button ID="btnsubmit" runat="server" Text="Submit" />
        </div>
    </form>
</body>
</html>
