using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AlchemyGamesv2._0
{
    public partial class removeItem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ShoppingCart.removeOne(Convert.ToInt32(Request.QueryString["ID"]));
            Response.Redirect("Cart.aspx");
        }
    }
}