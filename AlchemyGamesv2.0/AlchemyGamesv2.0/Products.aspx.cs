using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AlchemyGamesv2._0
{
    //<a href = "#" class="page-number"><i class="fa fa-angle-left"></i></a>
	//<span class="page-number current">1</span>
	//<a href = "#" class="page-number">2</a>
	//<a href = "#" class="page-number">3</a>
	//<a href = "#" class="page-number">...</a>
	//<a href = "#" class="page-number">12</a>
	//<a href = "#" class="page-number"><i class="fa fa-angle-right"></i></a>
    public partial class Products : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var pageType = Request.QueryString["ID"];
            var gametype = gameType.Value;
            var sortby = SortBy.Value;
            var genre = GameGenre.Value;
            //var numgames = NumGames.Value;

            switch (pageType)
            {
                case "PC":
                    Session["currentPage"] = "PC";
                    break;
                case "PS":
                    Session["currentPage"] = "PS";
                    break;
                case "Xbox":
                    Session["currentPage"] = "xbox";
                    break;
                case "Nintendo":
                    Session["currentPage"] = "nintendo";
                    break;
            }

            StringBuilder display = new StringBuilder();
            display.Clear();

            var db = new AlchemyLinkDataContext();

            dynamic games = from g in db.Products
                            where g.Platfrom.Equals(pageType) && g.Type.Equals(gametype)
                            select g;

            dynamic orders = from o in db.Order_Products
                             select o;

            List<int> popGamesCount = new List<int>();
            List<int> popGames = new List<int>();
            List<GameCount> popGameRating = new List<GameCount>();

            foreach(Order_Product o in orders)
            {
                popGamesCount.Add(o.ProductID);
            }

            popGames = popGamesCount.Distinct().ToList();

            for(int i = 0; i < popGames.Count; i++)
            {
                GameCount newGame = new GameCount();
                newGame.setGameID(popGames.ElementAt(i));
                newGame.setGameCount(0);
                popGameRating.Add(newGame);
            }

            for (int i = 0; i < popGameRating.Count; i++)
            {
                foreach (int id in popGamesCount)
                {
                    if (popGameRating.ElementAt(i).getGameID().Equals(id))
                    {
                        int count = popGameRating.ElementAt(i).getGameCount();
                        count++;
                        popGameRating.ElementAt(i).setGameCount(count);
                    }
                }
            }

            popGameRating = popGameRating.OrderByDescending(o => o.getGameCount()).ToList();

            if (genre.Equals("none"))
            {
                if (sortby.Equals("Pop"))
                {
                    List<int> rejectGames = new List<int>();
                    for(int i = 0; i < popGameRating.Count; i++)
                    {
                        Product prodR = popGameRating.ElementAt(i).GetProduct();

                        foreach (Product prod in games)
                        {
                            if (prodR.Id.Equals(prod.Id))
                            {
                                if (prod.StockLevels > 0)
                                {
                                    display.Append("<div class=\"product\">" + Environment.NewLine);
                                    display.Append("<div class=\"inner-product\">" + Environment.NewLine);
                                    display.Append("<div class=\"figure-image\">" + Environment.NewLine);
                                    display.Append("<a href =\"single.aspx?ID=" + prod.Id + "\">" + Environment.NewLine);
                                    display.Append("<img src=\"" + prod.ImageLink + "\"></a>" + Environment.NewLine);
                                    display.Append("</div>" + Environment.NewLine);
                                    display.Append("<h3 class=\"product-title\"><a href=\"Single.aspx?ID=" + prod.Id + "\">" + prod.Name + "</a></h3>" + Environment.NewLine);
                                    display.Append("<small class=\"price\">" + String.Format("{0:C2}", prod.Price) + "</small>" + Environment.NewLine);
                                    display.Append("<br />");
                                    display.Append("</div>" + Environment.NewLine);
                                    display.Append("</div>" + Environment.NewLine);
                                }
                            }
                            else
                            {
                                rejectGames.Add(prod.Id);
                            }
                        }
                    }

                    for(int i = 0; i < rejectGames.Count; i++)
                    {
                        Product prod = (from p in db.Products
                                        where p.Id.Equals(rejectGames.ElementAt(i))
                                        select p).FirstOrDefault();

                        if (prod.StockLevels > 0)
                        {
                            display.Append("<div class=\"product\">" + Environment.NewLine);
                            display.Append("<div class=\"inner-product\">" + Environment.NewLine);
                            display.Append("<div class=\"figure-image\">" + Environment.NewLine);
                            display.Append("<a href =\"single.aspx?ID=" + prod.Id + "\">" + Environment.NewLine);
                            display.Append("<img src=\"" + prod.ImageLink + "\"></a>" + Environment.NewLine);
                            display.Append("</div>" + Environment.NewLine);
                            display.Append("<h3 class=\"product-title\"><a href=\"Single.aspx?ID=" + prod.Id + "\">" + prod.Name + "</a></h3>" + Environment.NewLine);
                            display.Append("<small class=\"price\">" + String.Format("{0:C2}", prod.Price) + "</small>" + Environment.NewLine);
                            display.Append("<br />");
                            display.Append("</div>" + Environment.NewLine);
                            display.Append("</div>" + Environment.NewLine);
                        }
                    }
                }
                else if(sortby.Equals("High"))
                {
                    dynamic game = from g in db.Products
                                    where g.Platfrom.Equals(pageType) && g.Type.Equals(gametype)
                                    orderby g.Price descending
                                    select g;

                    foreach (Product prod in game)
                    {
                        if (prod.StockLevels > 0)
                        {
                            display.Append("<div class=\"product\">" + Environment.NewLine);
                            display.Append("<div class=\"inner-product\">" + Environment.NewLine);
                            display.Append("<div class=\"figure-image\">" + Environment.NewLine);
                            display.Append("<a href =\"single.aspx?ID=" + prod.Id + "\">" + Environment.NewLine);
                            display.Append("<img src=\"" + prod.ImageLink + "\"></a>" + Environment.NewLine);
                            display.Append("</div>" + Environment.NewLine);
                            display.Append("<h3 class=\"product-title\"><a href=\"Single.aspx?ID=" + prod.Id + "\">" + prod.Name + "</a></h3>" + Environment.NewLine);
                            display.Append("<small class=\"price\">" + String.Format("{0:C2}", prod.Price) + "</small>" + Environment.NewLine);
                            display.Append("<br />");
                            display.Append("</div>" + Environment.NewLine);
                            display.Append("</div>" + Environment.NewLine);
                        }
                    }
                }
                else if (SortBy.Equals("Low"))
                {
                    dynamic game = from g in db.Products
                                   where g.Platfrom.Equals(pageType) && g.Type.Equals(gametype)
                                   orderby g.Price ascending
                                   select g;

                    foreach (Product prod in game)
                    {
                        if (prod.StockLevels > 0)
                        {
                            display.Append("<div class=\"product\">" + Environment.NewLine);
                            display.Append("<div class=\"inner-product\">" + Environment.NewLine);
                            display.Append("<div class=\"figure-image\">" + Environment.NewLine);
                            display.Append("<a href =\"single.aspx?ID=" + prod.Id + "\">" + Environment.NewLine);
                            display.Append("<img src=\"" + prod.ImageLink + "\"></a>" + Environment.NewLine);
                            display.Append("</div>" + Environment.NewLine);
                            display.Append("<h3 class=\"product-title\"><a href=\"Single.aspx?ID=" + prod.Id + "\">" + prod.Name + "</a></h3>" + Environment.NewLine);
                            display.Append("<small class=\"price\">" + String.Format("{0:C2}", prod.Price) + "</small>" + Environment.NewLine);
                            display.Append("<br />");
                            display.Append("</div>" + Environment.NewLine);
                            display.Append("</div>" + Environment.NewLine);
                        }
                    }
                }
            }
            else
            {
                if (SortBy.Equals("Pop"))
                {
                    List<int> rejectGames = new List<int>();
                    for (int i = 0; i < popGameRating.Count; i++)
                    {
                        Product prodR = popGameRating.ElementAt(i).GetProduct();

                        foreach (Product prod in games)
                        {
                            if (prodR.Id.Equals(prod.Id))
                            {
                                if ((prod.StockLevels > 0) && (prod.Genre.Equals(genre)))
                                {
                                    display.Append("<div class=\"product\">" + Environment.NewLine);
                                    display.Append("<div class=\"inner-product\">" + Environment.NewLine);
                                    display.Append("<div class=\"figure-image\">" + Environment.NewLine);
                                    display.Append("<a href =\"single.aspx?ID=" + prod.Id + "\">" + Environment.NewLine);
                                    display.Append("<img src=\"" + prod.ImageLink + "\"></a>" + Environment.NewLine);
                                    display.Append("</div>" + Environment.NewLine);
                                    display.Append("<h3 class=\"product-title\"><a href=\"Single.aspx?ID=" + prod.Id + "\">" + prod.Name + "</a></h3>" + Environment.NewLine);
                                    display.Append("<small class=\"price\">" + String.Format("{0:C2}", prod.Price) + "</small>" + Environment.NewLine);
                                    display.Append("<br />");
                                    display.Append("</div>" + Environment.NewLine);
                                    display.Append("</div>" + Environment.NewLine);
                                }
                            }
                            else
                            {
                                rejectGames.Add(prod.Id);
                            }
                        }
                    }

                    for (int i = 0; i < rejectGames.Count; i++)
                    {
                        Product prod = (from p in db.Products
                                        where p.Id.Equals(rejectGames.ElementAt(i))
                                        select p).FirstOrDefault();

                        if ((prod.StockLevels > 0) && (prod.Genre.Equals(genre)))
                        {
                            display.Append("<div class=\"product\">" + Environment.NewLine);
                            display.Append("<div class=\"inner-product\">" + Environment.NewLine);
                            display.Append("<div class=\"figure-image\">" + Environment.NewLine);
                            display.Append("<a href =\"single.aspx?ID=" + prod.Id + "\">" + Environment.NewLine);
                            display.Append("<img src=\"" + prod.ImageLink + "\"></a>" + Environment.NewLine);
                            display.Append("</div>" + Environment.NewLine);
                            display.Append("<h3 class=\"product-title\"><a href=\"Single.aspx?ID=" + prod.Id + "\">" + prod.Name + "</a></h3>" + Environment.NewLine);
                            display.Append("<small class=\"price\">" + String.Format("{0:C2}", prod.Price) + "</small>" + Environment.NewLine);
                            display.Append("<br />");
                            display.Append("</div>" + Environment.NewLine);
                            display.Append("</div>" + Environment.NewLine);
                        }
                    }
                }
                else if (sortby.Equals("High"))
                {
                    dynamic game = from g in db.Products
                                   where g.Platfrom.Equals(pageType) && g.Type.Equals(gametype)
                                   orderby g.Price descending
                                   select g;

                    foreach (Product prod in game)
                    {
                        if ((prod.StockLevels > 0) && (prod.Genre.Equals(genre)))
                        {
                            display.Append("<div class=\"product\">" + Environment.NewLine);
                            display.Append("<div class=\"inner-product\">" + Environment.NewLine);
                            display.Append("<div class=\"figure-image\">" + Environment.NewLine);
                            display.Append("<a href =\"single.aspx?ID=" + prod.Id + "\">" + Environment.NewLine);
                            display.Append("<img src=\"" + prod.ImageLink + "\"></a>" + Environment.NewLine);
                            display.Append("</div>" + Environment.NewLine);
                            display.Append("<h3 class=\"product-title\"><a href=\"Single.aspx?ID=" + prod.Id + "\">" + prod.Name + "</a></h3>" + Environment.NewLine);
                            display.Append("<small class=\"price\">" + String.Format("{0:C2}", prod.Price) + "</small>" + Environment.NewLine);
                            display.Append("<br />");
                            display.Append("</div>" + Environment.NewLine);
                            display.Append("</div>" + Environment.NewLine);
                        }
                    }
                }
                else if (SortBy.Equals("Low"))
                {
                    dynamic game = from g in db.Products
                                   where g.Platfrom.Equals(pageType) && g.Type.Equals(gametype)
                                   orderby g.Price ascending
                                   select g;

                    foreach (Product prod in game)
                    {
                        if ((prod.StockLevels > 0) && (prod.Genre.Equals(genre)))
                        {
                            display.Append("<div class=\"product\">" + Environment.NewLine);
                            display.Append("<div class=\"inner-product\">" + Environment.NewLine);
                            display.Append("<div class=\"figure-image\">" + Environment.NewLine);
                            display.Append("<a href =\"single.aspx?ID=" + prod.Id + "\">" + Environment.NewLine);
                            display.Append("<img src=\"" + prod.ImageLink + "\"></a>" + Environment.NewLine);
                            display.Append("</div>" + Environment.NewLine);
                            display.Append("<h3 class=\"product-title\"><a href=\"Single.aspx?ID=" + prod.Id + "\">" + prod.Name + "</a></h3>" + Environment.NewLine);
                            display.Append("<small class=\"price\">" + String.Format("{0:C2}", prod.Price) + "</small>" + Environment.NewLine);
                            display.Append("<br />");
                            display.Append("</div>" + Environment.NewLine);
                            display.Append("</div>" + Environment.NewLine);
                        }
                    }
                }
            }
            prodList.InnerHtml = display.ToString();
            display.Clear();
        }
    }
}