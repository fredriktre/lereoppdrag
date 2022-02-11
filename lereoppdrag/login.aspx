<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="lereoppdrag.WebForm5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="StyleSheet1.css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox_Username" runat="server"></asp:TextBox>
            <br />
            <asp:TextBox ID="TextBox_Password" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button_Login" runat="server" Text="Login" OnClick="Button_Login_Click" />
        </div>
    </form>
</body>
</html>
