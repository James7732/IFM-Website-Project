using ifm_prac_3_v2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AlchemyGamesv2._0
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["Admin"] = null;
        }

        protected void Register_ServerClick(object sender, EventArgs e)
        {
            Usermsg.InnerHtml = "<h1 style=\"color: red\"> testing </h1>";
            var email = userEmail.Value;
            var UserName = username.Value;
            var Name = firstname.Value;
            var SurName = surname.Value;
            var Cell = phonenumber.Value;
            var PassWord = Secrecy.computeHash(password.Value);
            var ConfPass = Secrecy.computeHash(confpassword.Value);
            Boolean exists = false;

            var database = new AlchemyLinkDataContext();

            dynamic users = from u in database.Users
                            select u;

            if (PassWord.Equals(ConfPass))
            {

                foreach (User u in users)
                {
                    if (u.Username.Equals(username) || u.Email.Equals(email))
                    {
                        exists = true;
                    }
                }

                if (!exists)
                {
                    var NewUser = new User
                    {
                        FirstName = Name,
                        Email = email,
                        Username = UserName,
                        Surname = SurName,
                        Phone = Cell,
                        Password = PassWord,
                        Admin = false,
                        PostalAdress = null,
                        Suberb = null,
                        City = null,
                        Province = null,
                        PostalCode = null
                    };

                    try
                    {
                        database.Users.InsertOnSubmit(NewUser);
                        database.SubmitChanges();
                        Response.Redirect("Login.aspx");
                    }
                    catch (Exception ex)
                    {
                        ex.GetBaseException();
                        Usermsg.InnerHtml = "<h1 style=\"color: red\"> Registration Failed </h1>";

                    }
                }
                else if (exists)
                {
                    Usermsg.InnerHtml = "<h1 style=\"color: red\"> User Account Already In Use </h1>";
                }

            }
            else
            {
                Usermsg.InnerHtml = "<h1 style=\"color: red\"> Passwords Do Not Match </h1>";
            }
        }
    }
}