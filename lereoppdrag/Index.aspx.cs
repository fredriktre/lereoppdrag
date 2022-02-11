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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;

            //MembershipUser currentUser = Membership.GetUser();
            ////Get Username of Currently logged in user.
            //string username = currentUser.UserName;
            ////Get UserId of Currently logged in user.
            //string UserId = currentUser.ProviderUserKey.ToString();
        }           

        DBLayer db = new DBLayer();
        public void Button_HelpSend_Click(object sender, EventArgs e)
        {
            
            db.InsertHelp(EmailHelp: TextBox_EmailHelp.Text, HelpText: TextArea_HelpText.InnerText);
        }
    }
}