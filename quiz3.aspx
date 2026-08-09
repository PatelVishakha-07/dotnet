<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="quiz3.aspx.cs" Inherits="registration.quiz3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Q1. Which access modifier allows access only within the same class? <br />
            <asp:RadioButtonList ID="rdoq1" runat="server">
                <asp:ListItem Text="public" Value="public"></asp:ListItem>
                <asp:ListItem Text="private" Value="private"></asp:ListItem>
                <asp:ListItem Text="protected" Value="protected"></asp:ListItem>
            </asp:RadioButtonList> <br /><br />

             Q2. Which class cannot be instantiated? <br />
             <asp:RadioButtonList ID="rdoq2" runat="server">
                 <asp:ListItem Text="Static class" Value="Static class"></asp:ListItem>
                <asp:ListItem Text="Abstract class" Value="Abstract class"></asp:ListItem>
                <asp:ListItem Text="Partial class" Value="Partial class"></asp:ListItem>
             </asp:RadioButtonList> <br /><br />

            Q3. Which exception is thrown when dividing an integer by zero? <br />
            <asp:RadioButtonList ID="rdoq3" runat="server">
                <asp:ListItem Text="NullReferenceException" Value="NullReferenceException"></asp:ListItem>
                <asp:ListItem Text="ArithmeticException" Value="ArithmeticException"></asp:ListItem>
                <asp:ListItem Text="DivideByZeroException" Value="DivideByZeroException"></asp:ListItem>
            </asp:RadioButtonList> <br /><br />

            Q4. Which keyword is used for exception handling? <br />
            <asp:RadioButtonList ID="rdoq4" runat="server">
                <asp:ListItem Text="catch" Value="catch"></asp:ListItem>
                <asp:ListItem Text="throw" Value="throw"></asp:ListItem>
                <asp:ListItem Text="Both" Value="Both"></asp:ListItem>
            </asp:RadioButtonList> <br /><br />

            Q5. Which of these is NOT an OOP principle? <br />
            <asp:RadioButtonList ID="rdoq5" runat="server">
                <asp:ListItem Text="Encapsulation" Value="Encapsulation"></asp:ListItem>
                <asp:ListItem Text="Compilation" Value="Compilation"></asp:ListItem>
                <asp:ListItem Text="Inheritance" Value="Inheritance"></asp:ListItem>
            </asp:RadioButtonList> <br /><br />

            <asp:Button ID="btnsubmit" runat="server" Text="Submit" OnClick="btnsubmit_Click" /> <br /><br /><br />

            <asp:Label ID="lblscore" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
