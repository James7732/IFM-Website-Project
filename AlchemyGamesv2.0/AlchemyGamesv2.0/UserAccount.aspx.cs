using ifm_prac_3_v2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AlchemyGamesv2._0
{
    public partial class UserAccount : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
                var db = new AlchemyLinkDataContext();
                int UId = (int)Session["UserID"];
                dynamic invoices = from o in db.Orders
                                   where o.UserID.Equals(UId)
                                   select o;
                foreach (Order ord in invoices)
                {
                invList.InnerHtml += "<div class='product'>"
                                  + "<div class='inner-product'>"
                                  + "Date: " + ord.Date + "<br>"
                                  + "Invoice Total: " + String.Format("{0:C2}", ord.Amount) + " excl. Shipping @ R50 <br>"
                                  + "Item/s bought:" + "<br>";
                                      
                    //get order_product linked to order
                    dynamic invoiceItems = from i in db.Order_Products
                                           where i.OrderID.Equals(ord.Id)
                                           select i;
                    foreach (Order_Product invItem in invoiceItems)
                    {
                        //get product linked to order_product
                        Product prod = (from p in db.Products
                                        where p.Id.Equals(invItem.ProductID)
                                        select p).FirstOrDefault();
                        invList.InnerHtml += prod.Name + " " + prod.Platfrom + " - " + String.Format("{0:C2}", prod.Price) + "<br>";
                    }
                    invList.InnerHtml += "</div></div>";
                }
                Invoices.Visible = true;
                UserInfo.Visible = false;
            
        }

        protected void BtnInvoice_Click(object sender, EventArgs e)
        {
            Response.Redirect(Request.RawUrl);
            /*
                var db = new AlchemyLinkDataContext();
                int UId = (int)Session["UserID"];
                dynamic invoices = from o in db.Orders
                                   where o.UserID.Equals(UId)
                                   select o;
                foreach (Order ord in invoices)
                {
                    invList.InnerHtml += "<div class='product'>"
                                      + "<div class='inner-product'>"
                                      + "Date&Time: " + ord.Date + "<br>"
                                      + "Invoice Total: " + String.Format("{0:C2}", ord.Amount) + "<br>"
                                      + "Items bought:" + "<br>";
                    //get order_product linked to order
                    dynamic invoiceItems = from i in db.Order_Products
                                           where i.OrderID.Equals(ord.Id)
                                           select i;
                    foreach (Order_Product invItem in invoiceItems)
                    {
                        //get product linked to order_product
                        Product prod = (from p in db.Products
                                        where p.Id.Equals(invItem.ProductID)
                                        select p).FirstOrDefault();
                        invList.InnerHtml += prod.Name + " " + prod.Platfrom + " - " + String.Format("{0:C2}", prod.Price) + "<br>";
                    }
                    invList.InnerHtml += "</div></div>";
                }
                UserInfo.Visible = false;
                Invoices.Visible = true;
                */
        }

        protected void BtnUserInfo_Click(object sender, EventArgs e)
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
            UserInfo.Visible = true;
            Invoices.Visible = false;
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