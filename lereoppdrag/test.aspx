<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="test.aspx.cs" Inherits="lereoppdrag.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .left-test{
            margin-right: 5px;
        }
        .right-test{
            margin-left: 5px;
        }

        .dash{
            border-left: 2px solid black;
        }
    </style>
    <link rel="stylesheet" type="text/css" href="StyleSheet1.css" />
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

        <div style="transform: translate(-50%, 0); position: absolute; left: 50%;" id="wrapper_ButtonStartTest" runat="server" visible="true">
            <asp:Button ID="Button_StartTest" runat="server" Text="Start Test" OnClick="Button_StartTest_Click" />
            <br />
            <asp:Label ID="Label_Finished" runat="server" Visible="false" Text="Thank you for finishing the test!" style="color: white;"></asp:Label>
        </div>

        <div id="QuestionTextDiv" class="test-wrapper" runat="server" visible="false">
            <div>
                <asp:Label ID="QuestionText" runat="server" Text=" "></asp:Label>
            </div>

            <table id="TestTable" class="test-2size" runat="server" visible="false">
                <tr>
                    <td>
                        <div class="left-test">
                        <asp:Label ID="Label1" runat="server" Text="A"></asp:Label>
                        </div>
                        <asp:Image ID="Image1" runat="server" />
                        <asp:Label ID="Ans1" runat="server" Text=" "></asp:Label>
                    </td>

                    <td class="dash">

                    </td>

                    <td>
                        <div class="right-test">
                        <asp:Label ID="Label2" runat="server" Text="B"></asp:Label>
                        </div>
                        <asp:Image ID="Image2" runat="server" />
                        <asp:Label ID="Ans2" runat="server" Text=" "></asp:Label>
                    </td>
                </tr>                

                <tr>
                    <td>
                        <div class="left-test">
                        <asp:Label ID="Label4" runat="server" Text="C"></asp:Label>
                        </div>
                        <asp:Image ID="Image3" runat="server" />
                        <asp:Label ID="Ans3" runat="server" Text=" "></asp:Label>
                    </td>

                    <td class="dash">

                    </td>

                    <td>
                        <div class="right-test">
                        <asp:Label ID="Label6" runat="server" Text="D"></asp:Label>
                        </div>
                        <asp:Image ID="Image4" runat="server" />
                        <asp:Label ID="Ans4" runat="server" Text=" "></asp:Label>
                    </td>
                </tr>

            </table>

            <div id="AnswerList" class="insert-wrapper" runat="server" visible="false">
                <span class="list-wrapper">
                    <asp:DropDownList ID="DropDownList1" runat="server" CssClass="Dropdown" AutoPostBack="true">
                        <asp:ListItem>A</asp:ListItem>
                        <asp:ListItem>B</asp:ListItem>
                        <asp:ListItem>C</asp:ListItem>
                        <asp:ListItem>D</asp:ListItem>
                    </asp:DropDownList>
                <asp:Button ID="ButtonFortsett" runat="server" Text="Fortsett" Class="Dropdown" OnClick="ButtonFortsett_Click"/>
                </span>

            </div>
        </div>
    </form>
</body>
</html>
