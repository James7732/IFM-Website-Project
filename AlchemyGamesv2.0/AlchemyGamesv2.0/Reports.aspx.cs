using System;
using System.Collections;
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

        protected void btnMonth_Click(object sender, EventArgs e)
        {
            SalesPerMonth();
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

        private void SalesPerMonth()
        {
            int month = Convert.ToInt32(salesmonth.Value);

            var database = new AlchemyLinkDataContext();

            dynamic sales = from s in database.Orders where s.Date.Month.Equals(month) select s;

            double total = 0;

            foreach (Order o in sales)
            {
                total += o.Amount;
            }

            salespermonth.InnerHtml = "R" + Convert.ToString(total);
        }

        private void BusiestDay()
        {
            var database = new AlchemyLinkDataContext();

            dynamic date = from d in database.Orders where d.Date.Month.Equals(10) select d;

            ArrayList dates = new ArrayList();

            foreach(Order o in date)
            {
                dates.Add(o.Date.Date);
            }

            dates.Sort();

            foreach(int i in dates)
            {

            }
        }
    }
}