using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит информацию о процентной скидке.
    /// </summary>
    internal class PercentDiscount : IDiscount
    {
        /// <summary>
        /// Максимально возможная скидка.
        /// </summary>
        private const int maxDiscountPercentage = 10;

        /// <summary>
        /// Возвращает информацию, сколько было потрачено.
        /// </summary>
        public double TotalSpent { get; private set; }
        /// <summary>
        /// Возвращает категорию товаров.
        /// </summary>
        public Category Category { get; private set; }
        /// <summary>
        /// Возвращает текущую скидку.
        /// </summary>
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

        /// <summary>
        /// Создает экземпляр класса <see cref="PercentDiscount"/>
        /// </summary>
        /// <param name="category">Категория товара.</param>
        public PercentDiscount(Category category)
        {
            Category = category;
            CurrentDiscountPercentage = 1;
            TotalSpent = 0;
        }

        /// <summary>
        /// Рассчитывает размер скидки в процентах.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        public void Update(List<Item> items)
        {
            TotalSpent = CalculateTotalCost(items);
            CurrentDiscountPercentage = Math.Min(1 + (int)(TotalSpent / 1000), maxDiscountPercentage);
        }
        /// <summary>
        /// Рассчитывает размер скидки в рублях.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Возвращает размер скидки в рублях.</returns>
        public double Calculate(List<Item> items)
        {
            double discountAmount = 0;
            discountAmount = CalculateTotalCost(items) * CurrentDiscountPercentage / 100;
            
            return discountAmount;
        }

        /// <summary>
        /// Рассчитывает стоимость с учетом скидки.
        /// </summary>
        /// <param name="items">Список товаров</param>
        /// <returns>Стоимость с учетом скидки.</returns>
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
        /// <summary>
        /// Возвращает информацию в более удобной форме.
        /// </summary>
        /// <returns>Возвращает информацию.</returns>
        public override string ToString()
        {
            return Info;
        }
    }
}
