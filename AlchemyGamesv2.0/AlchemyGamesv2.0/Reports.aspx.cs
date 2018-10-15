using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace AlchemyGamesv2._0
{
    public partial class Reports : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                RegisteredUsers();
                ProductsSold();
            }

        }

        private void RegisteredUsers()
        {
            string connectionstring = Properties.Settings.Default.AlchemyDatabaseConnectionString;

            SqlConnection connection = new SqlConnection(connectionstring);

            connection.Open();

            string sql = "SELECT DateRegistered, Count(DateRegistered) AS NumberOfUsersRegistered FROM Users GROUP BY DateRegistered";

            SqlCommand command = new SqlCommand(sql, connection);

            SqlDataReader reader = command.ExecuteReader();

            GridViewRegistered.DataSource = reader;
            GridViewRegistered.DataBind();
        }

        private void ProductsSold()
        {
            string connectionstring = Properties.Settings.Default.AlchemyDatabaseConnectionString;

            SqlConnection connection = new SqlConnection(connectionstring);

            connection.Open();

            string sql = "SELECT Name, Platfrom, Type, StockLevels FROM Product";

            SqlCommand command = new SqlCommand(sql, connection);

            SqlDataReader reader = command.ExecuteReader();

            GridViewSold.DataSource = reader;
            GridViewSold.DataBind();
        }
    }
}