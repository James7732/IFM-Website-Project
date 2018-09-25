using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlchemyGamesv2._0
{
    public static class ShoppingCart
    {
        private static List<int> CartItems;

        public static void addItem(int itemToAdd)
        {
            CartItems.Add(itemToAdd);
        }

        public static void removeItem(int itemToRemove)
        {
            CartItems.Remove(itemToRemove);
        }

        public static List<int> getCartItems()
        {
            return CartItems;
        }
    }
}