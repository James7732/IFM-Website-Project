using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AlchemyGamesv2._0
{
    public partial class cart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var db = new AlchemyLinkDataContext();
           
            List<int> items = ShoppingCart.getCartItems().Distinct().ToList();
            StringBuilder display = new StringBuilder();

            for(int i = 0; i < items.Count; i++)
            {
                Product prod = (from p in db.Products
                                where p.Id.Equals(items.ElementAt(i))
                                select p).FirstOrDefault();

                display.Append("<tr>" + Environment.NewLine);
                display.Append("<td class=\"product-name\">" + Environment.NewLine);
                display.Append("<div class=\"product-thumbnail\">" + Environment.NewLine);
                display.Append("<img src=\"" + prod.ImageThumbLink +"\" />" + Environment.NewLine);
                display.Append("</div>" + Environment.NewLine);
                display.Append("<div class=\"product-detail\">" + Environment.NewLine);
                display.Append("<h3 class=\"product-title\">" + prod.Name +"</h3>" + Environment.NewLine);
                display.Append("<p>" + prod.Description +"</p>" + Environment.NewLine);
                display.Append("</div>" + Environment.NewLine);
                display.Append("</td>" + Environment.NewLine);
                display.Append("<td class=\"product-price\">R" + prod.Price +"</td>" + Environment.NewLine);
                display.Append("<td class=\"product-qty\">" + Environment.NewLine);
                display.Append("<select name=\"#\">" + Environment.NewLine);
                display.Append("<option value=\""+ ShoppingCart.getNumItems() +"\">"+ ShoppingCart.getNumItems() +"</option> " + Environment.NewLine);
                display.Append("</select>" + Environment.NewLine);
                display.Append("</td" + Environment.NewLine);
                display.Append("<td class=\"product-total\">R" + prod.Price*ShoppingCart.getNumProd(prod.Id) +"</td>" + Environment.NewLine);
                display.Append("<td class=\"action\"><a href=\"RemoveCartItem.aspx?ID="+ prod.Id +"\"><i class=\"fa fa-times\"></i></a></td>" + Environment.NewLine);
                display.Append("</tr>" + Environment.NewLine);

                cartDisplay.InnerHtml = display.ToString();
            }

            double subtotal = 0;
            double Total = 0;
            List<int> CartItems = ShoppingCart.getCartItems();
            for (int i = 0; i < CartItems.Count; i++)
            {
                var product = (from prod in db.Products
                               where prod.Id.Equals(CartItems.ElementAt(i))
                               select prod).FirstOrDefault();

                double price = Convert.ToDouble(product.Price);
                subtotal += price;
            }

            //the 50.0 is shipping fee
            //that should be based on wheather or not the product is hard copy
            //or digital
            Total = subtotal + 50.0;

            subTotal.InnerHtml = "<strong> Subtotal:</strong> R"+ subtotal +"";
            total.InnerHtml = "<strong>Total</strong><span class=\"num\">R"+ Total +"</span><strong>Total</strong><span class=\"num\">R"+ Total +"";
        }

        protected void BtnCheckout_Click(object sender, EventArgs e)
        {
            var db = new AlchemyLinkDataContext();

            if(Session["Admin"] != null)
            {
                Response.Redirect("Checkout.aspx");
            }
            else
            {
                Response.Redirect("Login.aspx?ID=checkout");
            }
        }
    }
}