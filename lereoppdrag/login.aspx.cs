using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;

namespace lereoppdrag
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        DBLayer dbLayer = new DBLayer();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button_Login_Click(object sender, EventArgs e)
        {
            string userName = TextBox_Username.Text;
            string passWord = TextBox_Password.Text;

            int exist = dbLayer.GetUserAndPassword(userName, passWord);
            if (exist == 1)
            {
                FormsAuthentication.RedirectFromLoginPage(TextBox_Username.Text, false);
            }
            else
                Response.Redirect("login.aspx", true);//todo add errormessage to user if wrong
        }
    }
}