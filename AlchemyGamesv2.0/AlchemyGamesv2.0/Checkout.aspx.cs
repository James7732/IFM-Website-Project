using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Collections;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;

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

                display += "Product Name: " + prod.Name + "<br/>";
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

            ShoppingCart.removeAll();

            try
            {
                StringReader sr = new StringReader("Hello");

                Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                HTMLWorker html = new HTMLWorker(pdfDoc);

                using (MemoryStream stream = new MemoryStream())
                {
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    html.Parse(sr);
                    pdfDoc.Close();

                    byte[] buffer = stream.ToArray();
                    stream.Close();

                    Response.Clear();
                    Response.ContentType = "application/pdf";
                    Response.AddHeader("Content-Disposition", "attachment; filename=Invoice.pdf");
                    Response.Buffer = true;
                    Response.Cache.SetCacheability(HttpCacheability.NoCache);
                    Response.BinaryWrite(buffer);
                    Response.End();
                    Response.Close();

                    btnCheckout.Enabled = false;
                }


            }
            catch(Exception e1)
            {
                Console.WriteLine(e1);

            }finally
            {
                
            }

        }

        protected void BtnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }

    }
}