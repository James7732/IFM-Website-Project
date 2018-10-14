using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AlchemyGamesv2._0
{
    public partial class LandinPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["currentPage"] = "home";

            var database = new AlchemyLinkDataContext();

            dynamic games = from g in database.Products where g.Platfrom.Equals("PC") select g;

            ArrayList randomArray = new ArrayList();

            foreach(Product p in games)
            {
                randomArray.Add(p.Id);
            }

            int max = randomArray.Count;

            Random rand = new Random();

            int index = rand.Next(max - 1);

            Console.WriteLine(max);
        }
    }
}