using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AlchemyGamesv2._0
{
    public partial class ProuductDeletion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var database = new AlchemyLinkDataContext();

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
            var op = from s in database.Order_Products where s.ProductID.Equals(id) select s;

            foreach(var q in op)
            {
                database.Order_Products.DeleteOnSubmit(q);
                foreach (var p in product)
                {

                    database.Products.DeleteOnSubmit(p);
                }
            }

            
            
            try
            {
                database.SubmitChanges();
                Response.Redirect("ProductDeletion.aspx");


            }catch(Exception e1)
            {
                Console.WriteLine(e1);
            }

        }
    }
}