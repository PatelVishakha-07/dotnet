<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="validations.aspx.cs" Inherits="registration.validations" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>            

            Name: <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                ErrorMessage="Name Cannot be empty" ControlToValidate="txtname"
                ForeColor="Red" Display="Dynamic">
            </asp:RequiredFieldValidator>
            <br /><br />

            Age: <asp:TextBox ID="txtage" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                ErrorMessage="Age cannot be empty" ControlToValidate="txtage"
                ForeColor="Red" Display="Dynamic">
            </asp:RequiredFieldValidator>

            <asp:RangeValidator 
                ID="RangeValidator1" runat="server" ControlToValidate="txtage"
                ErrorMessage="Enter valid age" MaximumValue="60" MinimumValue="18"
                ForeColor="Red" Display="Dynamic">
            </asp:RangeValidator>
            <br /><br /><br />

            <asp:Button ID="btnsubmit" runat="server" Text="Submit" OnClick="btnsubmit_Click" />

        </div>
    </form>
</body>
</html>
