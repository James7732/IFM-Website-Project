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
using System.Text;

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
                UserID = Convert.ToInt32(Session["UserID"]),
                Address = orderaddress.Value,
                Suberb = ordersuburb.Value,
                City = ordercity.Value,
                PostalCode = ordercode.Value

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

            

            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("<br/>");
                sb.Append("<h1><font size=10>Alchemy Games Invoice</font></h1>");
                sb.Append("<br/>");
                sb.Append("<br/>");
                sb.Append("<br/>");
                sb.Append("Customer Details: ");
                sb.Append("<br/>");

                User user = (from u in db.Users
                             where u.Id.Equals(Convert.ToInt32(Session["UserID"]))
                             select u).FirstOrDefault();

                sb.Append(user.FirstName);
                sb.Append(" ");
                sb.Append(user.Surname);
                sb.Append("<br/>");
                sb.Append(user.Email);
                sb.Append("<br/>");
                sb.Append("<br/>");
                sb.Append("Order Details: ");
                sb.Append("<br/>");

                double total = ShoppingCart.getTotal() + 50;

                sb.Append("R" + total + " (R50 Shipping)");
                sb.Append("<br/>");
                sb.Append(date);
                sb.Append("<br/>");



                dynamic invoiceItems = from i in db.Order_Products
                                       where i.OrderID.Equals(ordedrID.Id)
                                       select i;

                foreach (Order_Product invItem in invoiceItems)
                {
                    Product prod = (from p in db.Products
                                    where p.Id.Equals(invItem.ProductID)
                                    select p).FirstOrDefault();

                    sb.Append(prod.Name + " " + prod.Platfrom + " - " + String.Format("{0:C2}", prod.Price) + "<br>");
                }

                sb.Append("<br/>");
                sb.Append("<br/>");
                sb.Append("Shipping Details:");
                sb.Append("<br/>");
                sb.Append(orderaddress.Value);
                sb.Append("<br/>");
                sb.Append(ordersuburb.Value);
                sb.Append("<br/>");
                sb.Append(ordercity.Value);
                sb.Append("<br/>");
                sb.Append(orderprovince.Value);
                sb.Append("<br/>");
                sb.Append(ordercode.Value);


                StringReader sr = new StringReader(sb.ToString());

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

            ShoppingCart.removeAll();
            Response.Redirect("Payment.aspx");
        }

    }
}