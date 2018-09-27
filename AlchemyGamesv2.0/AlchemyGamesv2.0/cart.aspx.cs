using System;
using System.Collections.Generic;
using System.Linq;
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

            List<int> items = ShoppingCart.getCartItems();
            String display = "";

            for(int i = 0; i < items.Count; i++)
            {
                Product prod = (from p in db.Products
                                where p.Id.Equals(items.ElementAt(i))
                                select p).FirstOrDefault();

                display = "<tr>" + Environment.NewLine;
                display += "<td class=\"product-name\">" + Environment.NewLine;
                display += "<div class=\"product-thumbnail\">" + Environment.NewLine;
                display += "<img src=\"images\\"+ prod.ImageLink +"\" />" + Environment.NewLine;
                display = "</div>" + Environment.NewLine;
                display = "<div class=\"product-detail\">" + Environment.NewLine;
                display = "<h3 class=\"product-title\">"+ prod.Name +"</h3>" + Environment.NewLine;
                display = "<p>"+ prod.Description +"</p>" + Environment.NewLine;
                display = "</div>" + Environment.NewLine;
                display = "</tr>" + Environment.NewLine;
                display = "<td class=\"product-price\">R"+ prod.Price +"</td>" + Environment.NewLine;
                display = "<td class=\"product-qty\">" + Environment.NewLine;
                display = "<select name=\"#\">" + Environment.NewLine;
                display = "<option value=\"1\">1</option> "+ Environment.NewLine +" <option value=\"2\">2</option> "+ Environment.NewLine +" <option value=\"3\">3</option> " + Environment.NewLine;
                display = "</select>" + Environment.NewLine;
                display = "<td class=\"product-total\">"+ prod.Price +"</td>" + Environment.NewLine;
                display = "<td class=\"action\"><a href=\"#\"><i class=\"fa fa-times\"></i></a></td>" + Environment.NewLine;
                display = "</tr>" + Environment.NewLine;

                cartDisplay.InnerHtml = display;

                display = "";
            }
        }
    }
}