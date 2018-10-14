using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AlchemyGamesv2._0
{
    public partial class EditAProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var database = new AlchemyLinkDataContext();

            dynamic game = from g in database.Products where g.Id.Equals(Request.QueryString["Id"]) select g;

            foreach(Product p in game)
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
        }

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
    }
}