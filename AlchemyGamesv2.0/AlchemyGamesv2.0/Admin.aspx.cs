using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AlchemyGamesv2._0
{
    public partial class Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            editProd.Visible = true;
            addProd.Visible = false;
            deleteProd.Visible = false;
            report.Visible = false;
            if (!IsPostBack)
            {
                //MostCopiesSold();
                RegisteredUsers();
                ProductsSold();
            }

            var database = new AlchemyLinkDataContext();

            dynamic game = from g in database.Products where g.Id.Equals(Request.QueryString["Id"]) select g;

            foreach (Product p in game)
            {
                actualname.InnerHtml = "<font size=5> Name: " + p.Name + "</font>";
                actualprice.InnerHtml = "<font size=5> Price: " + String.Format("{0:C2}", p.Price) + "</font>";
                actualdescription.InnerHtml = "<font size=5> Description: " + p.Description + "</font>";
                actualimage.InnerHtml = "<img src=" + p.ImageLink + ">";
                actualstock.InnerHtml = "<font size=5> Stock: " + p.StockLevels + "</font>";
                actualplatform.InnerHtml = "<font size=5> Platform: " + p.Platfrom + "</font>";
                actualtype.InnerHtml = "<font size=5> Type: " + p.Type + "</font>";
                actualgenre.InnerHtml = "<font size=5> Genre: " + p.Genre + "</font>";
            }

            //var database = new AlchemyLinkDataContext();

            dynamic games = from g in database.Products select g;

            string display = " ";

            foreach (Product p in games)
            {
                display += p.Id + " " + p.Name + " " + p.Platfrom;
                display += "<br />";
            }

            productlist.InnerHtml = display;
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            var database = new AlchemyLinkDataContext();

            int id = Convert.ToInt32(productid.Value);

            var product = from p in database.Products where p.Id.Equals(id) select p;

            foreach (var p in product)
            {
                database.Products.DeleteOnSubmit(p);
            }

            try
            {
                database.SubmitChanges();
                Response.Redirect("ProductDeletion.aspx");


            }
            catch (Exception e1)
            {
                Console.WriteLine(e1);
            }

        }

        protected void btnMonth_Click(object sender, EventArgs e)
        {
            SalesPerMonth();
        }

        protected void BtnEditProd_Click(object sender, EventArgs e)
        {
            editProd.Visible = true;
            addProd.Visible = false;
            deleteProd.Visible = false;
            report.Visible = false;
        }

        protected void BtnAddProd_Click(object sender, EventArgs e)
        {
            editProd.Visible = false;
            addProd.Visible = true;
            deleteProd.Visible = false;
            report.Visible = false;
        }

        protected void BtnDeleteProd_Click(object sender, EventArgs e)
        {
            editProd.Visible = false;
            addProd.Visible = false;
            deleteProd.Visible = true;
            report.Visible = false;
        }

        protected void BtnReport_Click(object sender, EventArgs e)
        {
            editProd.Visible = false;
            addProd.Visible = false;
            deleteProd.Visible = false;
            report.Visible = true;
        }

        //======================================================
        protected void btnName_Click(object sender, EventArgs e)
        {
            var database = new AlchemyLinkDataContext();

            Product game = (from g in database.Products where g.Id.Equals(Request.QueryString["Id"]) select g).SingleOrDefault();

            game.Name = newname.Value;

            try
            {
                database.SubmitChanges();
                Response.Redirect(Request.RawUrl);

            }
            catch (Exception e1)
            {
                Console.WriteLine(e1);
            }
        }

        protected void btnPrice_Click(object sender, EventArgs e)
        {
            var database = new AlchemyLinkDataContext();

            Product game = (from g in database.Products where g.Id.Equals(Request.QueryString["Id"]) select g).SingleOrDefault();

            game.Price = Convert.ToInt32(newprice.Value);

            try
            {
                database.SubmitChanges();
                Response.Redirect(Request.RawUrl);

            }
            catch (Exception e1)
            {
                Console.WriteLine(e1);
            }
        }

        protected void btnDes_Click(object sender, EventArgs e)
        {
            var database = new AlchemyLinkDataContext();

            Product game = (from g in database.Products where g.Id.Equals(Request.QueryString["Id"]) select g).SingleOrDefault();

            game.Description = newdescription.Value;

            try
            {
                database.SubmitChanges();
                Response.Redirect(Request.RawUrl);

            }
            catch (Exception e1)
            {
                Console.WriteLine(e1);
            }
        }

        protected void btnImage_Click(object sender, EventArgs e)
        {
            var database = new AlchemyLinkDataContext();

            Product game = (from g in database.Products where g.Id.Equals(Request.QueryString["Id"]) select g).SingleOrDefault();

            game.ImageLink = newimage.Value;

            try
            {
                database.SubmitChanges();
                Response.Redirect(Request.RawUrl);

            }
            catch (Exception e1)
            {
                Console.WriteLine(e1);
            }
        }

        protected void btnStock_Click(object sender, EventArgs e)
        {
            var database = new AlchemyLinkDataContext();

            Product game = (from g in database.Products where g.Id.Equals(Request.QueryString["Id"]) select g).SingleOrDefault();

            game.StockLevels = Convert.ToInt32(newstock.Value);

            try
            {
                database.SubmitChanges();
                Response.Redirect(Request.RawUrl);

            }
            catch (Exception e1)
            {
                Console.WriteLine(e1);
            }
        }

        protected void btnPlatform_Click(object sender, EventArgs e)
        {
            var database = new AlchemyLinkDataContext();

            Product game = (from g in database.Products where g.Id.Equals(Request.QueryString["Id"]) select g).SingleOrDefault();

            game.Platfrom = newplatform.Value;

            try
            {
                database.SubmitChanges();
                Response.Redirect(Request.RawUrl);

            }
            catch (Exception e1)
            {
                Console.WriteLine(e1);
            }
        }

        protected void btnType_Click(object sender, EventArgs e)
        {
            var database = new AlchemyLinkDataContext();

            Product game = (from g in database.Products where g.Id.Equals(Request.QueryString["Id"]) select g).SingleOrDefault();

            game.Type = newtype.Value;

            try
            {
                database.SubmitChanges();
                Response.Redirect(Request.RawUrl);

            }
            catch (Exception e1)
            {
                Console.WriteLine(e1);
            }
        }

        protected void btnGenre_Click(object sender, EventArgs e)
        {
            var database = new AlchemyLinkDataContext();

            Product game = (from g in database.Products where g.Id.Equals(Request.QueryString["Id"]) select g).SingleOrDefault();

            game.Genre = newgenre.Value;

            try
            {
                database.SubmitChanges();
                Response.Redirect(Request.RawUrl);

            }
            catch (Exception e1)
            {
                Console.WriteLine(e1);
            }
        }
        //======================================================
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            var database = new AlchemyLinkDataContext();

            var NewProduct = new Product
            {
                Name = productname.Value,
                Price = Convert.ToDecimal(productprice.Value),
                Description = productdescription.Value,
                ImageLink = productimage.Value,
                StockLevels = Convert.ToInt32(productstock.Value),
                Platfrom = productplatform.Value,
                Type = producttype.Value,
                Genre = productgenre.Value

            };

            try
            {
                database.Products.InsertOnSubmit(NewProduct);
                database.SubmitChanges();
                Response.Redirect("ProductAddition.aspx");
            }
            catch (Exception e1)
            {
                Console.WriteLine(e1);

            }
        }
        //======================================================

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

            foreach (Order_Product order in copies)
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

            foreach (Order_Product order in copies)
            {
                gamesSold.Add(order.ProductID);
            }

            listOfUniqueGames = gamesSold.Distinct().ToList();

            for (int i = 0; i < listOfUniqueGames.Count; i++)
            {
                int count = 0;
                foreach (int id in gamesSold)
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

            foreach (Order o in date)
            {
                dates.Add(o.Date.Date);
            }

            dates.Sort();

            foreach (int i in dates)
            {

            }
        }
    }
}