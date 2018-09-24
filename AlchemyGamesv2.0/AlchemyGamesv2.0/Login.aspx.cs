using ifm_prac_3_v2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AlchemyGamesv2._0
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["Admin"] = null;
        }

        protected void Login_ServerClick(object sender, EventArgs e)
        {
            var Email = email.Value;
            var Password = Secrecy.computeHash(password.Value);

            var db = new AlchemyLinkDataContext();

            var user = (from User u in db.Users
                        where u.Email.Equals(Email) && u.Password.Equals(Password)
                        select u).FirstOrDefault();
           
            if(user != null)
            {
                Session["Admin"] = user.Admin;
                Response.Redirect("HomePage.aspx");
            } else
            {
                userMsg.InnerHtml = "<h1 style=\"color: red\">User details not found. Please try again.</h1>";
            }
        }
    }
}