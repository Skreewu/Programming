using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Сервисный класс, который хранит инструменты для работы с данными.
    /// </summary>
    internal static class DataTools
    {
        /// <summary>
        /// Фильтрует список по заданному критерию.
        /// </summary>
        /// <param name="items">Список объектов.</param>
        /// <param name="compare">Заданный критерий.</param>
        /// <returns>Отфильтрованный список.</returns>
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
        /// <summary>
        /// Сортирует список по заданному критерию.
        /// </summary>
        /// <param name="items">Список объектов.</param>
        /// <param name="compare">Заданный критерий.</param>
        /// <returns>Отсортированный список.</returns>
        public static List<Item> Sort(List<Item> items, Func<Item, Item, bool> compare)
        {
            List<Item> newItems = items;
            for (int i = 0; i < newItems.Count; i++)
            {
                for (int j = 1; j < newItems.Count; j++)
                {
                    if (compare(newItems[j], newItems[j - 1]))
                    {
                        var temp = newItems[j];
                        newItems[j] = newItems[j - 1];
                        newItems[j - 1] = temp;
                    }
                }
            }
            return newItems;
        }
    }
}
