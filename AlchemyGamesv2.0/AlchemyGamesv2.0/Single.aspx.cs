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

            display = "<div class=\"col-sm-6 col-md-4\">" + Environment.NewLine;
            display += "<div class=\"product-images\">" + Environment.NewLine;
            display += "<figure class=\"large-image\">" + Environment.NewLine;
            display += "<a href=\"" + game.ImageLink + "\" >" + Environment.NewLine;
            display += "<img src=\"" + game.ImageFullLink + "\"/></a>" + Environment.NewLine;
            display += "</figure>" + Environment.NewLine;
            display += "</div>" + Environment.NewLine;
            display += "</div>" + Environment.NewLine;

            iheader.InnerHtml = display;

            display = "<h2 class=\"entry-title\">"+ game.Name +"</h2>" + Environment.NewLine;
            display += "<small class=\"price\">"+ game.Price +"</small>" + Environment.NewLine;
            display += "<p>"+ game.Description +"</p>" + Environment.NewLine;

            ibody.InnerHtml = display;
        }

        protected void AddToCart_Click(object sender, EventArgs e)
        {
            var prodID = Request.QueryString["ID"];
            int val = Convert.ToInt32(prodQuant.Value);
            ShoppingCart.addItem(Convert.ToInt32(prodID), val);
            Page.Response.Redirect(Page.Request.Url.ToString(), true);
        }
    }
}