using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AlchemyGamesv2._0
{
    public partial class UpdateCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ShoppingCart.addItem(Convert.ToInt32(Request.QueryString["ID"]), 1);
            Response.Redirect("Cart.aspx");
        }
    }
}