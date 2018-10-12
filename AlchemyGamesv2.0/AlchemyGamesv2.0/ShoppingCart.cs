using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlchemyGamesv2._0
{
    public static class ShoppingCart
    {
        private static List<int> CartItems = new List<int>();

        public static void addItem(int itemToAdd, int numItems)
        {
            for(int i = 0; i < numItems; i++)
            {
                CartItems.Add(itemToAdd);
            }
        }

        public static void removeItem(int itemToRemove)
        {
            for(int i = 0; i < CartItems.Count; i++)
            {
                if(CartItems.ElementAt(i) == itemToRemove)
                {
                    CartItems.RemoveAt(i);
                }
            }
        }

        public static List<int> getCartItems()
        {
            return CartItems;
        }

        public static int getItem(int index)
        {
            return CartItems.ElementAt(index);
        }

        public static int getNumItems()
        {
            return CartItems.Count;
        }

        public static int getNumProd(int itemID)
        {
            int retVal = 0;
            for(int i = 0; i < CartItems.Count; i++)
            {
                if(CartItems.ElementAt(i) == itemID)
                {
                    retVal++;
                }
            }
            return retVal;
        }
    }
}