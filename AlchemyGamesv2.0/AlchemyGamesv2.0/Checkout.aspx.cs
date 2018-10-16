using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using iText.Layout;
using iText.Kernel.Pdf;
using iText.Layout.Element;
using System.IO;

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

            display = "<font size=6>Review Order</font>" + "<br/><br/>";
            display += "Username: " + user.Username + "<br/><br/>";
            foreach(int id in ShoppingCart.getCartItems())
            {
                Product prod = (from p in db.Products
                               where p.Id.Equals(id)
                               select p).FirstOrDefault();

                display += "Products Name: " + prod.Name + "<br/>";
                display += "Price: " + String.Format("{0:C2}", prod.Price) + "<br/><br/>";
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

            //cartDetails.InnerHtml = "<h1 style=\"color: red\">Check Out Successful, Invoice Saved to Desktop, Redirecting to Home...</h1>";

            try
            {
                var exportfolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                var exportfile = Path.Combine(exportfolder, "Invoice.pdf");
                var writer = new PdfWriter(exportfile);
                var pdf = new PdfDocument(writer);
                var document = new Document(pdf);
                document.Add(new Paragraph("Alchemy Games"));
                document.Close();

                Response.Redirect("Pdf.aspx");
            }
            catch
            {
            }
            
            ShoppingCart.removeAll();

        }
    }
}