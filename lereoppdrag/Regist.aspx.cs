using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;

namespace lereoppdrag
{
    public partial class WebForm6 : System.Web.UI.Page
    {
            DBLayer dbLayer = new DBLayer();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button_Register_Click(object sender, EventArgs e)
        {
            dbLayer.RegisterUser(username: TextBox_UserName.Text, password: TextBox_Password.Text, email: TextBox_Email.Text);
        }
    }
}