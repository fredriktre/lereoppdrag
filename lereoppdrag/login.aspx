<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="lereoppdrag.WebForm5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="StyleSheet1.css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="nav-wrapper">
            <div class="left-side">              

                <div class="nav-link-wrapper active-nav-link text-pad">
                    <a href="Index.aspx">Forside</a>
                </div>

                <div class="nav-link-wrapper text-pad">
                    <a href="video.aspx">Video</a>
                </div>

                <div class="nav-link-wrapper text-pad">
                    <a href="lese.aspx">lesemateriale</a>
                </div>

                <div class="nav-link-wrapper text-pad">
                    <a href="test.aspx">testside</a>
                </div>

                <div id="makeq_wrapper" class="nav-link-wrapper text-pad" runat="server" visible="true">
                    <a href="makequestion.aspx">make question</a>
                </div>                
            </div>
                        
            <div class="right-side">
                <div id="Login" class="nav-link-wrapper text-pad" runat="server">
                    <asp:LoginName ID="LoginName1" runat="server" visible="false"/>
                    <asp:LoginStatus ID="LoginStatus1" runat="server" visible="false"/>
                    <a href="Regist.aspx">Register</a>               
                </div>                                       
            </div>
            

        </div>
        <div style="display: flex; justify-content: center; ">
            <asp:TextBox ID="TextBox_Username" runat="server" placeholder="Username"></asp:TextBox>
            <br />
            <asp:TextBox ID="TextBox_Password" runat="server" placeholder="Password"></asp:TextBox>
            <br />
            <asp:Button ID="Button_Login" runat="server" Text="Login" OnClick="Button_Login_Click" />
        </div>
    </form>
</body>
</html>
