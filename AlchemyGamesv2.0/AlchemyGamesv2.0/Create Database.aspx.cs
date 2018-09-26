using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AlchemyGamesv2._0
{
    public partial class Loadaspx : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connString = null;
            connString = global::System.Configuration.ConfigurationManager.ConnectionStrings["AlchemyGamesv2._0.Properties.Settings.AlchemyDatabaseConnectionString"].ConnectionString;

            if (connString.Contains("|DataDirectory|"))
            {
                string dataDirectory = AppDomain.CurrentDomain.GetData("DataDirectory").ToString();
                connString = connString.Replace("|DataDirectory|", dataDirectory);
            }

            using (AlchemyLinkDataContext ctx = new AlchemyLinkDataContext(connString))
            {
                if (ctx.DatabaseExists() == false)
                {
                    ctx.CreateDatabase();
                }
            }
        }
    }
}