﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

            switch (pageType)
            {
                case "PC":
                    Session["currentPage"] = "PC";
                    break;
                case "PS":
                    Session["currentPage"] = "PS";
                    break;
                case "Xbox":
                    Session["currentPage"] = "xbox";
                    break;
                case "Nintendo":
                    Session["currentPage"] = "nintendo";
                    break;
            }

            StringBuilder display = new StringBuilder();

            var db = new AlchemyLinkDataContext();

            dynamic games = from g in db.Products
                            where g.Platfrom.Equals(pageType)
                            select g;

            System.Web.UI.HtmlControls.HtmlButton btn = new System.Web.UI.HtmlControls.HtmlButton();
            btn.ID = "btnCart";
            btn.Attributes["class"] = "button";
            btn.ServerClick += new EventHandler(AddToCart_ServerClick);
            btn.InnerHtml = "add to cart";
            foreach (Product prod in games)
            {
                display.Append("<div class=\"product\">" + Environment.NewLine);
                display.Append("<div class=\"inner-product\">" + Environment.NewLine);
                display.Append("<div class=\"figure-image\">" + Environment.NewLine);
                display.Append("<a href =\"single.aspx?ID=" + prod.Id + "\">" + Environment.NewLine);
                display.Append("<img src=\"" + prod.ImageLink + "\" alt=\"Game 1\"></a>" + Environment.NewLine);
                display.Append("</div>" + Environment.NewLine);
                display.Append("<h3 class=\"product-title\"><a href=\"Single.aspx?ID=" + prod.Id + "\">" + prod.Name + "</a></h3>" + Environment.NewLine);
                display.Append("<small class=\"price\">" + String.Format("{0:C2}", prod.Price) +"</small>" + Environment.NewLine);
                display.Append("<p>" + prod.Genre +"</p>" + Environment.NewLine);
                display.Append("<br />");
                display.Append("<button class=\"button\" runat=\"server\" type=\"button\" onserverclick=\"AddToCart_ServerClick?ID=" + prod.Id + "\">Add to cart</button>" + Environment.NewLine);
                display.Append("<a href=\"Single.aspx?ID=" + prod.Id +"\" class=\"button muted\">Read Details</a>" + Environment.NewLine);
                display.Append("</div>" + Environment.NewLine);
                display.Append("</div>" + Environment.NewLine);

                prodList.InnerHtml = display.ToString();
            }
            display.Clear();
        }

        protected void AddToCart_ServerClick(object sender, EventArgs e)
        {
            testMsg.InnerHtml = "WORKS!";
            var db = new AlchemyLinkDataContext();

            var item = (from Product prod in db.Products
                       where prod.Id.Equals(Request.QueryString["ID"])
                       select prod).FirstOrDefault();

            ShoppingCart.addItem(item.Id, 1);
        }
    }
}