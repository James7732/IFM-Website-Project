using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AlchemyGamesv2._0
{
    public partial class InvoiceList : System.Web.UI.Page
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

        }


    }
}