using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AlchemyGamesv2._0
{
    public partial class ProductPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var database = new AlchemyLinkDataContext();

            string display = "";

            var game = (from Product g in database.Products
                           where g.Id.Equals(Request.QueryString["ID"])
                           select g).FirstOrDefault();

            display = "<div class=\"entry-content>" + Environment.NewLine;
            display += "<div class=\"row\">" + Environment.NewLine;
            display += "<div class=\"col-sm-6 col-md-4\">" + Environment.NewLine;
            display += "<div class=\"product-images\">" + Environment.NewLine;
            display += "<figure class=\"large-image\">" + Environment.NewLine;
            display += "<a href=\"" + game.ImageLink + "\" >" + Environment.NewLine;
            display += "<img src=\"" + game.ImageLink + "\"/></a>" + Environment.NewLine;
            display += "</figure>" + Environment.NewLine;
            display += "</div>" + Environment.NewLine;
            display += "</div>" + Environment.NewLine;
            display += "<div class=\"col-sm-6 col-md-8\">" + Environment.NewLine;
            display += "<h2 class=\"entry-title\">Need for Speed Rivals</h2>" + Environment.NewLine;
            display += "<small class=\"price\">$190.00</small>" + Environment.NewLine;
            display += "<h2 class=\"ntry-title\">Need for Speed Rivals</h2>" + Environment.NewLine;
            display += "<p>" + game.Description + "</p>" + Environment.NewLine;
            //display += "<p>descr</p>" + Environment.NewLine;
            //display += "<p>descr</p>" + Environment.NewLine;
            //display += "<div class=\"addtocart-bar\">" + Environment.NewLine;
            //display += "<label for=\"#\"> Quantity </label>" + Environment.NewLine;
            //display += "<select id=\"prodQuant\" runat=\"server\" name=\"quantity\">" + Environment.NewLine;
            //display += "<option value=\"1\">1</option>" + Environment.NewLine;
            //display += "<option value=\"2\">2</option>" + Environment.NewLine;
            //display += "<option value=\"3\">3</option>" + Environment.NewLine;
            //display += "</select>" + Environment.NewLine;
            //display += "<a href=\"ShoppingCart.aspx?ID="+ game.Id +"\" class=\"button\">Add to cart</a>" + Environment.NewLine;
            //display += "</div>" + Environment.NewLine;
            display += "</div>" + Environment.NewLine;
            display += "</div>" + Environment.NewLine;
            display += "</div>" + Environment.NewLine;

            iheader.InnerHtml = display;
        }

        protected void AddToCart_Click(object sender, EventArgs e)
        {

        }
    }
}