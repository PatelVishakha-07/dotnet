<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="student.aspx.cs" Inherits="registration.student" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Roll no: <asp:TextBox ID="txtrno" runat="server"></asp:TextBox> <br /><br />
            Name: <asp:TextBox ID="txtname" runat="server"></asp:TextBox> <br /><br />

            <asp:DropDownList ID="drpdept" runat="server">
                <asp:ListItem Text="MCA" Value="MCA"></asp:ListItem>
                <asp:ListItem Text="BCA" Value="BCA"></asp:ListItem>
                <asp:ListItem Text="MSCIT" Value="MSCIT"></asp:ListItem>
                <asp:ListItem Text="BSCIT" Value="BSCIT"></asp:ListItem>
            </asp:DropDownList> <br /><br />

            <asp:RadioButtonList ID="rdosemester" runat="server">
                <asp:ListItem Text="1" Value="1"></asp:ListItem>
                <asp:ListItem Text="2" Value="2"></asp:ListItem>
                <asp:ListItem Text="3" Value="3"></asp:ListItem>
                <asp:ListItem Text="4" Value="4"></asp:ListItem>
                <asp:ListItem Text="5" Value="5"></asp:ListItem>
                <asp:ListItem Text="6" Value="6"></asp:ListItem>
            </asp:RadioButtonList> <br /><br />

            <asp:CheckBoxList ID="chkelective" runat="server">
                <asp:ListItem Text="AI" Value="AI"></asp:ListItem>
                <asp:ListItem Text="Cloud Computing" Value="Cloud Computing"></asp:ListItem>
                <asp:ListItem Text="Cyber Security" Value="Cyber Security"></asp:ListItem>
            </asp:CheckBoxList> <br /><br />

            <asp:DropDownList ID="drplab" runat="server">
                <asp:ListItem Text="A" Value="A"></asp:ListItem>
                <asp:ListItem Text="B" Value="B"></asp:ListItem>
                <asp:ListItem Text="C" Value="C"></asp:ListItem>
            </asp:DropDownList> <br /><br />

            <asp:Button ID="btnsubmit" runat="server" Text="Submit" OnClick="btnsubmit_Click" /> 
            
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            
            <asp:Button ID="btndisplay" runat="server" Text="Display" OnClick="btndisplay_Click" /> <br /><br />
            <br />

            <asp:Label ID="lbldata" runat="server" Text=""></asp:Label>

        </div>
    </form>
</body>
</html>
