﻿using System;
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

            List<int> items = ShoppingCart.getCartItems();
            StringBuilder display = new StringBuilder();

            for (int i = 0; i < items.Count; i++)
            {
                Product prod = (from p in db.Products
                                where p.Id.Equals(items.ElementAt(i))
                                select p).FirstOrDefault();

                display.Append("<tr>" + Environment.NewLine);
                display.Append("<td class=\"product-name\">" + Environment.NewLine);
                display.Append("<div class=\"product-thumbnail\">" + Environment.NewLine);
                display.Append("<img src=\"images\\" + prod.ImageLink +"\" />" + Environment.NewLine);
                display.Append("</div>" + Environment.NewLine);
                display.Append("<div class=\"product-detail\">" + Environment.NewLine);
                display.Append("<h3 class=\"product-title\">" + prod.Name +"</h3>" + Environment.NewLine);
                display.Append("<p>" + prod.Description +"</p>" + Environment.NewLine);
                display.Append("</div>" + Environment.NewLine);
                display.Append("</tr>" + Environment.NewLine);
                display.Append("<td class=\"product-price\">R" + prod.Price +"</td>" + Environment.NewLine);
                display.Append("<td class=\"product-qty\">" + Environment.NewLine);
                display.Append("<select name=\"#\">" + Environment.NewLine);
                display.Append("<option value=\"1\">1</option> " + Environment.NewLine +" <option value=\"2\">2</option> "+ Environment.NewLine +" <option value=\"3\">3</option> " + Environment.NewLine);
                display.Append("</select>" + Environment.NewLine);
                display.Append("<td class=\"product-total\">" + prod.Price +"</td>" + Environment.NewLine);
                display.Append("<td class=\"action\"><a href=\"#\"><i class=\"fa fa-times\"></i></a></td>" + Environment.NewLine);
                display.Append("</tr>" + Environment.NewLine);

                cartDisplay.InnerHtml = display.ToString();
            }
        }
    }
}