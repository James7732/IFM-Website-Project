using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlchemyGamesv2._0
{
    public class GameCount
    {
        private int gameID;
        private int gameCount;
        
        public Product GetProduct()
        {
            var db = new AlchemyLinkDataContext();
            var prod = (from p in db.Products
                        where p.Id.Equals(gameID)
                        select p).FirstOrDefault();
            return prod;
        }

        public int getGameID()
        {
            return gameID;
        }

        public int getGameCount()
        {
            return gameCount;
        }

        public void setGameID(int id)
        {
            gameID = id;
        }

        public void setGameCount(int count)
        {
            gameCount = count;
        }
    }
}