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

            var db = new AlchemyLinkDataContext();

            dynamic games = from g in db.Products
                            where g.Platfrom.Equals(pageType)
                            select g;
            
            foreach(Product prod in games)
            {

            }
        }
    }
}