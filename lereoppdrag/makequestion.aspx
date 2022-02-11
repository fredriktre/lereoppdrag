<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="makequestion.aspx.cs" Inherits="lereoppdrag.WebForm4" %>

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

            </div>

        </div>

        <div class="make-wrapper">

            <table class="make-content-wrapper">
                    <tr>
                        <td>
                            <asp:Label ID="Label1" runat="server" Text="Question" style="color: white;"></asp:Label>
                            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                            <asp:Label ID="LabelWrong1" runat="server" Text="Invalid" Visible="false" style="color: red; font-weight: bold;"></asp:Label>
                        </td>                        
                    </tr>

                    <tr>
                        <td>
                            <asp:Label ID="Label2" runat="server" Text="Answer1" style="color: white;"></asp:Label>
                            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                            <asp:Label ID="LabelWrong2" runat="server" Text="Invalid" Visible="false" style="color: red; font-weight: bold;"></asp:Label>
                        </td>                        
                    </tr>

                    <tr>
                        <td>
                            <asp:Label ID="Label3" runat="server" Text="Answer2" style="color: white;"></asp:Label>
                            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                            <asp:Label ID="LabelWrong3" runat="server" Text="Invalid" Visible="false" style="color: red; font-weight: bold;"></asp:Label>
                        </td>                        
                    </tr>

                    <tr>
                        <td>
                            <asp:Label ID="Label4" runat="server" Text="Answer3" style="color: white;"></asp:Label>
                            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                            <asp:Label ID="LabelWrong4" runat="server" Text="Invalid" Visible="false" style="color: red; font-weight: bold;"></asp:Label>
                        </td>                        
                    </tr>
                    
                    <tr>
                        <td>
                            <asp:Label ID="Label5" runat="server" Text="Answer4" style="color: white;"></asp:Label>
                            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                            <asp:Label ID="LabelWrong5" runat="server" Text="Invalid" Visible="false" style="color: red; font-weight: bold;"></asp:Label>
                        </td>                        
                    </tr>
                
                    <tr class="make-content-wrapper finish-button">
                        <asp:Label ID="Label6" runat="server" Text="Correct answer" style="color: white;"></asp:Label>
                        <asp:DropDownList ID="DropDownList1" runat="server">
                            <asp:ListItem>answerA</asp:ListItem>
                            <asp:ListItem>answerB</asp:ListItem>
                            <asp:ListItem>answerC</asp:ListItem>
                            <asp:ListItem>answerD</asp:ListItem>
                        </asp:DropDownList>                
                        <asp:Button ID="Button6" runat="server" Text="finish" OnClick="Button6_Click"/>                     
                    </tr>
                </table>                                

            <div class="grid-wrapper">
                <asp:GridView ID="GridView1" runat="server" style="border:4px solid green; background-color: lightgrey;"></asp:GridView>
                <asp:Button ID="Button1" runat="server" Text="Refresh Grid" OnClick="Button1_Click" />
            </div>
        </div>        
    </form>
</body>
</html>
