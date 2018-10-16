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