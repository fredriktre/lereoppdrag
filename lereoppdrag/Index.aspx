<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="lereoppdrag.WebForm1" %>

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

        <div class="welcome-wrapper" style="text-align: center;">
            <div class="welcome-text-wrapper">
                <h1>Velkommen til Tutotech</h1>
                <br />
                <p>Her vil du kunne lære om hvordan man bruker Open Broadcaster Software!</p>
                <p>Fra å sette opp programmet helt til streaming og opptak!</p>
                <p>For nå, så funker desverre ikke lesemateriale- og video-sidene, plis vær tolmodig med de.</p>
                <br />                
            </div>            
        </div>

            <div style="color: white; transform: translate(-50%, 0); position: absolute; left: 50%; text-align: center;" runat="server">
                <p>Hvis det er noe du lurer på, så kan du sende det i boksen under, så skal jeg ta en titt på det.</p>

                <div>
                    <asp:TextBox ID="TextBox_EmailHelp" runat="server" Text="" placeholder="Email"></asp:TextBox>
                </div>
                    
                <div runat="server">
                    <textarea id="TextArea_HelpText" cols="20" rows="2" runat="server" style="height: 50px; width: 100%;" placeholder="Hjelpetext"></textarea>
                </div>

                <div>
                    <asp:Button ID="Button_HelpSend" runat="server" Text="Send" OnClick="Button_HelpSend_Click"/>
                </div>

            </div>

    </form>
</body>
</html>
