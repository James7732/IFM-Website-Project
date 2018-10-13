using System;
using ifm_prac_3_v2;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AlchemyGamesv2._0
{
    public partial class UserManagement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Change_Click(object sender, EventArgs e)
        {
            var db = new AlchemyLinkDataContext();
            //this line prevents conflict exception when updating multiple fields
            db.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues);

            //fix after login is working again
            //int currentUserID = (int)Session["UserID"];
            var currentUser = (from User u in db.Users
                               where u.Id.Equals(2)
                               select u).FirstOrDefault();

            if (email.Value != "")
            {
                currentUser.Email = email.Value;
            }

            if (password.Value != "" && password.Value == cPassword.Value)
            {
                currentUser.Password = Secrecy.computeHash(password.Value);   
            }

            if (fName.Value != "")
            {
                currentUser.FirstName = fName.Value;
            }

            if (sName.Value != "")
            {
                currentUser.Surname = sName.Value;
            }

            if (pNumber.Value != "")
            {
                currentUser.Phone = pNumber.Value;
            }

            if (uName.Value != "")
            {
                currentUser.Username = uName.Value;
            }
            db.SubmitChanges();
            email.Value = "";
            password.Value = "";
            cPassword.Value = "";
            fName.Value = "";
            sName.Value = "";
            pNumber.Value = "";
            uName.Value = "";
        }
    }
}