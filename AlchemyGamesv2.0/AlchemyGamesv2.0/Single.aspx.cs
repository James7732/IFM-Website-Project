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

            dynamic games = from g in database.Products where g.Id.Equals(Request.QueryString["Id"]) select g;

            foreach(Product p in games)
            {
                display += "<h1>" + p.Name + "</h1>";
                display += "<img src=" + p.ImageLink +">";
                display += "<p1>" + p.Description + "</p1>";
            }

            iheader.InnerHtml = display;
        }
    }
}