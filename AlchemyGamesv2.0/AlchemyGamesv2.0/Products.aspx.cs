using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AlchemyGamesv2._0
{
    public partial class Products : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var pageType = Request.QueryString["ID"];
            String display = "";

            var db = new AlchemyLinkDataContext();

            dynamic games = from g in db.Products
                            where g.Platfrom.Equals(pageType)
                            select g;


            //<div class="product">
            //            <div class="inner-product">
            //                <div class="figure-image">
            //                    <a href = "single.html" >
            //                        < img src="dummy/game-1.jpg" alt="Game 1"></a>
            //                </div>
            //                <h3 class="product-title"><a href = "#" > Alpha Protocol</a></h3>
            //                <small class="price">$19.00</small>
            //                <p>Lorem ipsum dolor sit consectetur adipiscing elit do eiusmod tempor...</p>
            //                <a href = "#" class="button">Add to cart</a>
            //                <a href = "#" class="button muted">Read Details</a>
            //            </div>
            //        </div>

            foreach(Product prod in games)
            {
                display = "<div class=\"product\">" + Environment.NewLine;
                display += "<div class=\"inner-product\">" + Environment.NewLine;
                display += "<div class=\"figure-image\">" + Environment.NewLine;
                display += "<a href =\"single.html?ID="+ prod.Id +"\">" + Environment.NewLine;
                display += "<img src=\""+ prod.ImageLink +"\" alt=\"Game 1\"></a>" + Environment.NewLine;
                display += "</div>" + Environment.NewLine;
                display += "<h3 class=\"product-title\"><a href=\"single.html?ID=" + prod.Id + "\">"+ prod.Name +"</a></h3>" + Environment.NewLine;
                display += "<small class=\"price\">R"+ prod.Price +"</small>" + Environment.NewLine;
                display += "<p>"+ prod.Description +"</p>" + Environment.NewLine;
                display += "<button class=\"button\" runat=\"server\" type=\"button\" onserverclick=\"AddToCart_ServerClick?ID="+ prod.Id +"\">Add to cart</button>" + Environment.NewLine;
                display += "<a href=\"Single.aspx?ID="+ prod.Id +"\" class=\"button muted\">Read Details</a>" + Environment.NewLine;
                display += "</div>" + Environment.NewLine;
                display += "</div>" + Environment.NewLine;

                prodList.InnerHtml = display;
                display = "";
            }
        }

        protected void AddToCart_ServerClick(object sender, EventArgs e)
        {
            var db = new AlchemyLinkDataContext();

            var item = (from Product prod in db.Products
                       where prod.Id.Equals(Request.QueryString["ID"])
                       select prod).FirstOrDefault();

            ShoppingCart.addItem(item.Id);
        }
    }
}