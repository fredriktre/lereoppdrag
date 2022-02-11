<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Regist.aspx.cs" Inherits="lereoppdrag.WebForm6" %>

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
                    <asp:LoginName ID="LoginName1" runat="server" />
                    <asp:LoginStatus ID="LoginStatus1" runat="server" />
                </div>
            </div>

            
        </div>

            <table style="display: flex; justify-content: center;">
                <tr>
                    <td>
                        <asp:Label ID="Label_Disclaimer" runat="server" Text="Disclaimer" style="color:white;"></asp:Label>
                    </td>

                </tr>

                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Vi har enda ikke et passord krypterings-system. så plis bruk et nytt passord du husker." style="color:white"></asp:Label>
                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:TextBox ID="TextBox_UserName" placeholder="Username" runat="server"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:TextBox ID="TextBox_Password" placeholder="Password" AutoCompleteType="None" runat="server"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:TextBox ID="TextBox_Email" placeholder="Email" runat="server"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:Button ID="Button_Register" runat="server" Text="Register" OnClick="Button_Register_Click" />
                    </td>
                </tr>
            </table>
    </form>
</body>
</html>
