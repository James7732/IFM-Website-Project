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
                //MostCopiesSold();
                RegisteredUsers();
                ProductsSold();
            }

        }

        protected void btnMonth_Click(object sender, EventArgs e)
        {
            SalesPerMonth();
           // Page.Response.Redirect(Page.Request.Url.ToString(), true);
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

        private void MostCopiesSold()
        {
            var db = new AlchemyLinkDataContext();
            List<int> mostGames = new List<int>();

            dynamic copies = from o in db.Order_Products
                             select o;

            foreach(Order_Product order in copies)
            {
                mostGames.Add(order.ProductID);
            }

            int most = mostGames.GroupBy(i => i).OrderByDescending(grp => grp.Count()).Select(grp => grp.Key).First();

            Product p = (from prod in db.Products
                         where prod.Id.Equals(most)
                         select prod).FirstOrDefault();

            //p contains the product that sold the most copies. The most baught game...
        }

        private void TotalSoldPerGame()
        {
            var db = new AlchemyLinkDataContext();
            List<int> gamesSold = new List<int>();
            List<int> listOfUniqueGames = new List<int>();
            List<GameCount> totalPerGame = new List<GameCount>();

            dynamic copies = from o in db.Order_Products
                             select o;

            foreach(Order_Product order in copies)
            {
                gamesSold.Add(order.ProductID);
            }

            listOfUniqueGames = gamesSold.Distinct().ToList();

            for(int i = 0; i < listOfUniqueGames.Count; i++)
            {
                int count = 0;
                foreach(int id in gamesSold)
                {
                    if (id.Equals(listOfUniqueGames.ElementAt(i)))
                    {
                        count++;
                    }
                }

                GameCount game = new GameCount();
                game.setGameCount(count);
                game.setGameID(listOfUniqueGames.ElementAt(i));
                totalPerGame.Add(game);
            }

            //totalPerGame now has the total copies sold per game with its corrosponding game ID
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