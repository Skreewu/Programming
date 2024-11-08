using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    internal class PercentDiscount
    {
        private const int maxDiscountPercentage = 10;

        public double TotalSpent { get; private set; }
        public Category Category { get; private set; }
        public int CurrentDiscountPercentage { get; private set; }

        /// <summary>
        /// Возвращает информацию о скидке.
        /// </summary>
        public string Info
        {
            get
            {
                return $"Процентная '{Category}' - {CurrentDiscountPercentage}%";
            }
        }

        public PercentDiscount(Category category)
        {
            Category = category;
            CurrentDiscountPercentage = 1;
            TotalSpent = 0;
        }

        public void Update(List<Item> items)
        {
            TotalSpent = CalculateTotalCost(items);
            CurrentDiscountPercentage = Math.Min(1 + (int)(TotalSpent / 1000), maxDiscountPercentage);
        }
        public double Calculate(List<Item> items)
        {
            double discountAmount = 0;
            discountAmount = CalculateTotalCost(items) * CurrentDiscountPercentage / 100;
            
            return discountAmount;
        }

        public double Apply(List<Item> items)
        {
            return CalculateTotalCost(items) - Calculate(items);
        }
        /// <summary>
        /// Считает стоимость всего списка товаров.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Возвращает стоимость.</returns>
        private double CalculateTotalCost(List<Item> items)
        {
            double totalCost = 0;
            foreach (var item in items)
            {
                if (item.Category == Category)
                {
                    totalCost += item.Cost;
                }
            }
            return totalCost;
        }
    }
}
