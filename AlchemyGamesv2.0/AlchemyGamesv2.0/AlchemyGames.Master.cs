using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AlchemyGamesv2._0
{
    public partial class AlchemyGames : System.Web.UI.MasterPage
    {
        public List<int> CartItems1;

        internal List<int> CartItems;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Admin"] != null)
            {
                if (!(bool)Session["Admin"])
                {
                    login.Visible = false;
                    logout.Visible = true;
                    adminPage.Visible = false;
                    account.Visible = true;
                } else
                {
                    logout.Visible = true;
                    login.Visible = false;
                    adminPage.Visible = true;
                    account.Visible = true;
                }
            } else
            {
                login.Visible = true;
                logout.Visible = false;
                register.Visible = true;
                adminPage.Visible = false;
                account.Visible = false;
            }
        }
    }
}