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

        public static void removeOne(int id)
        {
            CartItems.Remove(id);
        }

        public static void removeItem(int itemToRemove)
        {
            CartItems.RemoveAll(i => i.Equals(itemToRemove));
        }

        public static double getTotal()
        {
            var db = new AlchemyLinkDataContext();
            double total = 0;

            for(int i = 0; i < CartItems.Count; i++)
            {
                Product prod = (from p in db.Products
                                where p.Id.Equals(CartItems.ElementAt(i))
                                select p).FirstOrDefault();
                total += Convert.ToDouble(prod.Price);
            }

            return total;
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

        public static void removeAll()
        {
            CartItems.RemoveRange(0, CartItems.Count);
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