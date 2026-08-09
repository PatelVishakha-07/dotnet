<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="quiz2.aspx.cs" Inherits="registration.quiz2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Q1. Which OOP principle hides implementation details? <br />
            <asp:RadioButtonList ID="rdoq1" runat="server">
                <asp:ListItem Text="Inheritance" Value="Inheritance"></asp:ListItem>
                <asp:ListItem Text="Encapsulation" Value="Encapsulation"></asp:ListItem>
                <asp:ListItem Text="Abstraction" Value="Abstraction"></asp:ListItem>
            </asp:RadioButtonList> <br /><br />

             Q2. Which OOP principle allows one class to acquire properties of another? <br />
             <asp:RadioButtonList ID="rdoq2" runat="server">
                 <asp:ListItem Text="Inheritance" Value="Inheritance"></asp:ListItem>
                <asp:ListItem Text="Encapsulation" Value="Encapsulation"></asp:ListItem>
                <asp:ListItem Text="Abstraction" Value="Abstraction"></asp:ListItem>
             </asp:RadioButtonList> <br /><br />

            Q3. Which keyword is used to create an object in C#?<br />
            <asp:RadioButtonList ID="rdoq3" runat="server">
                <asp:ListItem Text="object" Value="object"></asp:ListItem>
                <asp:ListItem Text="class" Value="class"></asp:ListItem>
                <asp:ListItem Text="new" Value="new"></asp:ListItem>
            </asp:RadioButtonList> <br /><br />

            Q4. CLR stands for? <br />
            <asp:RadioButtonList ID="rdoq4" runat="server">
                <asp:ListItem Text="Common Language Runtime" Value="Common Language Runtime"></asp:ListItem>
                <asp:ListItem Text="Common Library Runtime" Value="Common Library Runtime"></asp:ListItem>
                <asp:ListItem Text="Core Language Runtime" Value="Core Language Runtime"></asp:ListItem>
            </asp:RadioButtonList> <br /><br />

            Q5. JIT stands for? <br />
            <asp:RadioButtonList ID="rdoq5" runat="server">
                <asp:ListItem Text="Just In Time" Value="Just In Time"></asp:ListItem>
                <asp:ListItem Text="Java Intermediate Translation" Value="Java Intermediate Translation"></asp:ListItem>
                <asp:ListItem Text="Just Internal Translation" Value="Just Internal Translation"></asp:ListItem>
            </asp:RadioButtonList> <br /><br />

            <asp:Button ID="btnnext" runat="server" Text="Next" OnClick="btnnext_Click" />

        </div>
    </form>
</body>
</html>
