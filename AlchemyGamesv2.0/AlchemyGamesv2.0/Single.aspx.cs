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

            int quantity = Convert.ToInt32(game.StockLevels);

            if(quantity > 3)
            {
                quantity = 3;
            }

            if(quantity == 1)
            {
                DropDownList1.Items.Remove("2");
                DropDownList1.Items.Remove("3");
            } else if(quantity == 2)
            {
                DropDownList1.Items.Remove("3");
            }

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
            display += "<small class=\"price\">"+ String.Format("{0:C2}", game.Price) + "</small>" + Environment.NewLine;
            display += "<p>"+ game.Description +"</p>" + Environment.NewLine;

            ibody.InnerHtml = display;
        }

        protected void AddToCart_Click(object sender, EventArgs e)
        {
            List<int> items = ShoppingCart.getCartItems();
            var prodID = Request.QueryString["ID"];
            int val = Convert.ToInt32(DropDownList1.SelectedItem.Value);
            int count = 0;

            if (items.Count > 0)
            {
                for(int i = 0; i < items.Count; i++)
                {
                    if (items.ElementAt(i).Equals(Convert.ToInt32(prodID)))
                    {
                        count += 1;
                    }
                }

                if((count + val) > 3)
                {
                    cartMsg.InnerHtml = "You may not buy more than 3 of the same games at a time";
                }
                else
                {
                    ShoppingCart.addItem(Convert.ToInt32(prodID), val);
                    Page.Response.Redirect(Page.Request.Url.ToString(), true);
                }
            }
            else
            {
                ShoppingCart.addItem(Convert.ToInt32(prodID), val);
                Page.Response.Redirect(Page.Request.Url.ToString(), true);
            }
        }
    }
}