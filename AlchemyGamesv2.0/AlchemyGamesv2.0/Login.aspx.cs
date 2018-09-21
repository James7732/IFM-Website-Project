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

        }

        protected void Login_ServerClick(object sender, EventArgs e)
        {
            var email = username.Value;
            var Password = Secrecy.computeHash(password.Value);

            var db = new AlchemyLinkDataContext();

                var user = from User u in db.Users
                           where u.Email.Equals(email)
                           select u;
            
        }
    }
}