<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DatingGame.aspx.cs" Inherits="DatingGame.DatingGame" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Welcome to the Dating Game!!!<br />
            <br />
            Name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Go" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" style="height: 26px" Text="Read" />
        </div>
        <asp:TextBox ID="name" runat="server"></asp:TextBox>
        <br />
        Question:<br />
        <asp:TextBox ID="question" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
        <br />
        Question-Response:<br />
        <asp:TextBox ID="questionR" runat="server" Width="300px"></asp:TextBox>
        <br />
        <asp:ListBox ID="ListBox1" runat="server" Height="129px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" Width="325px">
            <asp:ListItem></asp:ListItem>
        </asp:ListBox>
    </form>
</body>
</html>
