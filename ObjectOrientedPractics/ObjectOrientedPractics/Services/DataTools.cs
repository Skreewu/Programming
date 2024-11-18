using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.Services
{
    internal static class DataTools
    {
        public static List<Item> Filter(List<Item> items, Func<Item, bool> compare)
        {
            List<Item> newItems = new List<Item>();
            foreach (Item item in items)
            {
                if (compare(item))
                {
                    newItems.Add(item);
                }
            }
            return newItems;
        }
    }
}
