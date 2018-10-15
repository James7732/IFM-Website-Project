using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;

namespace AlchemyGamesv2._0
{
    public partial class Checkout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string display = "";
            var db = new AlchemyLinkDataContext();

            User user = (from u in db.Users
                         where u.Id.Equals(Convert.ToInt32(Session["UserID"]))
                         select u).FirstOrDefault();

            display = "Review products" + "<br/>";
            display += "Usernam: " + user.Username + "<br/>";
            foreach(int id in ShoppingCart.getCartItems())
            {
                Product prod = (from p in db.Products
                               where p.Id.Equals(id)
                               select p).FirstOrDefault();

                display += "Products name: " + prod.Name + "<br/>";
                display += "Price: " + prod.Price + "<br/>";
            }
            cartDetails.InnerHtml = display;
        }

        protected void BtnCheckout_Click(object sender, EventArgs e)
        {
            var date = DateTime.Now.Date;
            var time = DateTime.Now.TimeOfDay;
            var order = new Order
            {
                Amount = ShoppingCart.getTotal(),
                Date = date,
                Time = time,
                UserID = Convert.ToInt32(Session["UserID"])
            };

            var db = new AlchemyLinkDataContext();
            db.Orders.InsertOnSubmit(order);
            db.SubmitChanges();

            var ordedrID = (from o in db.Orders
                            where o.Date.Equals(date) && o.Time.Equals(time)
                            select o).FirstOrDefault();

            foreach(int prodID in ShoppingCart.getCartItems())
            {
                var product = (from p in db.Products
                               where p.Id.Equals(prodID)
                               select p).ToList().FirstOrDefault();
                product.StockLevels = product.StockLevels - 1;
                db.SubmitChanges();


                var oderProd = new Order_Product
                {
                    OrderID = ordedrID.Id,
                    ProductID = prodID
                };

                db.Order_Products.InsertOnSubmit(oderProd);
                db.SubmitChanges();
            }

            ShoppingCart.removeAll();

            cartDetails.InnerHtml = "<h1 style=\"color: red\">Items checked out</h1>";
        }
    }
}