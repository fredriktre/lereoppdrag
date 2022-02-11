<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm6.aspx.cs" Inherits="lereoppdrag.WebForm6" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="StyleSheet1.css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="">
            <asp:TextBox ID="TextBox_UserName" runat="server"></asp:TextBox>
            <br />
            <asp:TextBox ID="TextBox_Password" runat="server" AutoCompleteType="None"></asp:TextBox>
            <br />
            <asp:TextBox ID="TextBox_Email" runat="server"></asp:TextBox>
        </div>
    </form>
</body>
</html>
