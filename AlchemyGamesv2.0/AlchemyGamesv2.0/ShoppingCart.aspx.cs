using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AlchemyGamesv2._0
{
    public partial class ShoppingCart1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var prodID = Request.QueryString["ID"];
            ShoppingCart.addItem(Convert.ToInt32(prodID), 1);
            Response.Redirect("Single.aspx?ID="+ prodID +"");
        }
    }
}