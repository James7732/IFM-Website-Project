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
            var db = new AlchemyLinkDataContext();
            int currentUserID = (int)Session["UserID"];
            var currentUser = (from User u in db.Users
                               where u.Id.Equals(currentUserID)
                               select u).FirstOrDefault();
            accountInfo.InnerHtml = "Email: " + currentUser.Email + "<br>" +
                "First Name: " + currentUser.FirstName + "<br>" +
                "Surname: " + currentUser.Surname + "<br>" +
                "Phone Number: " + currentUser.Phone + "<br>" +
                "Username: " + currentUser.Username + "<br>";
        }

        protected void Change_Click(object sender, EventArgs e)
        {
            var db = new AlchemyLinkDataContext();
            //this line prevents conflict exception when updating multiple fields
            db.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues);

            int currentUserID = (int)Session["UserID"];
            var currentUser = (from User u in db.Users
                               where u.Id.Equals(currentUserID)
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
            Response.Redirect("UserManagement.aspx");
        }
    }
}