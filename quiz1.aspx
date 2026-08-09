<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="quiz1.aspx.cs" Inherits="registration.quiz1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Q1. Flutter is developed by? <br />
            <asp:RadioButtonList ID="rdoq1" runat="server">
                <asp:ListItem Text="Microsoft" Value="Microsoft"></asp:ListItem>
                <asp:ListItem Text="Google" Value="Google"></asp:ListItem>
                <asp:ListItem Text="Apple" Value="Apple"></asp:ListItem>
            </asp:RadioButtonList> <br /><br />

             Q2. Which widget is immutable? <br />
             <asp:RadioButtonList ID="rdoq2" runat="server">
                 <asp:ListItem Text="StatefulWidget" Value="StatefulWidget"></asp:ListItem>
                 <asp:ListItem Text="Scaffold" Value="Scaffold"></asp:ListItem>
                 <asp:ListItem Text="StatelessWidget" Value="StatelessWidget"></asp:ListItem>
             </asp:RadioButtonList> <br /><br />

            Q3. Which method rebuilds the Flutter UI? <br />
            <asp:RadioButtonList ID="rdoq3" runat="server">
                <asp:ListItem Text="setState()" Value="setState()"></asp:ListItem>
                <asp:ListItem Text="dispose()" Value="dispose()"></asp:ListItem>
                <asp:ListItem Text="initState()" Value="initState()"></asp:ListItem>
            </asp:RadioButtonList> <br /><br />

            Q4. Android is based on which operating system? <br />
            <asp:RadioButtonList ID="rdoq4" runat="server">
                <asp:ListItem Text="Linux" Value="Linux"></asp:ListItem>
                <asp:ListItem Text="Windows" Value="Windows"></asp:ListItem>
                <asp:ListItem Text="macOS" Value="macOS"></asp:ListItem>
            </asp:RadioButtonList> <br /><br />

            Q5. Django follows which architecture? <br />
            <asp:RadioButtonList ID="rdoq5" runat="server">
                <asp:ListItem Text="MVC" Value="MVC"></asp:ListItem>
                <asp:ListItem Text="MVT" Value="MVT"></asp:ListItem>
                <asp:ListItem Text="MVP" Value="MVP"></asp:ListItem>
            </asp:RadioButtonList> <br /><br />

             Q6. Laravel is written in? <br />
             <asp:RadioButtonList ID="rdoq6" runat="server">
                 <asp:ListItem Text="Java" Value="Java"></asp:ListItem>
                 <asp:ListItem Text="Python" Value="Python"></asp:ListItem>
                 <asp:ListItem Text="PHP" Value="PHP"></asp:ListItem>
             </asp:RadioButtonList> <br /><br />

            Q7. Which HTTP method is used to retrieve data? <br />
            <asp:RadioButtonList ID="rdoq7" runat="server">
                <asp:ListItem Text="POST" Value="POST"></asp:ListItem>
                <asp:ListItem Text="GET" Value="GET"></asp:ListItem>
                <asp:ListItem Text="PUT" Value="PUT"></asp:ListItem>
            </asp:RadioButtonList> <br /><br />

            Q8. Which data structure follows LIFO? <br />
            <asp:RadioButtonList ID="rdoq8" runat="server">
                <asp:ListItem Text="Queue" Value="Queue"></asp:ListItem>
                <asp:ListItem Text="Stack" Value="Stack"></asp:ListItem>
                <asp:ListItem Text="Tree" Value="Tree"></asp:ListItem>
            </asp:RadioButtonList> <br /><br />

            Q9.Time complexity of Binary Search? <br />
            <asp:RadioButtonList ID="rdoq9" runat="server">             
                <asp:ListItem Text="O(log n)" Value="O(log n)"></asp:ListItem>
                <asp:ListItem Text="O(1)" Value="O(1)"></asp:ListItem>
                <asp:ListItem Text="O(n)" Value="O(n)"></asp:ListItem>
            </asp:RadioButtonList> <br /><br />

            Q10. Which Python data type is immutable? <br />
            <asp:RadioButtonList ID="rdoq10" runat="server">
                <asp:ListItem Text="Tuple" Value="Tuple"></asp:ListItem>
                <asp:ListItem Text="List" Value="List"></asp:ListItem>
                <asp:ListItem Text="Set" Value="Set"></asp:ListItem>
            </asp:RadioButtonList> <br /><br />

            <asp:Button ID="btnnext" runat="server" Text="Next" OnClick="btnnext_Click" />

        </div>
    </form>
</body>
</html>
