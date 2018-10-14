using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AlchemyGamesv2._0
{
    public partial class SelectProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var database = new AlchemyLinkDataContext();

            dynamic games = from g in database.Products select g;

            string display = " ";

            foreach (Product p in games)
            {
                display += p.Id + " " + p.Name + " " + p.Platfrom + " ";
                display += "<a href=EditProduct.aspx?Id=" + p.Id + " > Edit </a>";
                display += "<br />";
            }

            productlist.InnerHtml = display;
        }
    }
}