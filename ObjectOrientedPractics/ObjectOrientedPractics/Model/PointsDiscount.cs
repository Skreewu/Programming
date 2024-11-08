using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о скидке.
    /// </summary>
    internal class PointsDiscount
    {
        /// <summary>
        /// Хранит данные о накопительных баллах.
        /// </summary>
        private int _points;

        /// <summary>
        /// Задает и возвращает накопительные баллы.
        /// </summary>
        public int Points
        {
            get
            {
                return _points;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Value must be positive");
                }
                _points = value;
            }
        }
        public string Info
        {
            get { return $"Накопительная – {Points} баллов"; }
        }
        public PointsDiscount() { }
        /// <summary>
        /// Расчитывает размер скидки.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Возвращает размер скидки.</returns>
        public double Calculate(List<Item> items)
        {
            double maxDiscount = CalculateTotalCost(items) * 0.30;
            double discount = Math.Min(Points, maxDiscount);

            return discount;
        }
        /// <summary>
        /// Применяет скидку, списывая баллы.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Возвращает размер скидки.</returns>
        public double Apply(List<Item> items)
        {
            double discount = Calculate(items);
            Points -= (int)discount;

            return CalculateTotalCost(items) - discount;
        }
        /// <summary>
        /// Начисляет баллы после покупки.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        public void Update(List<Item> items)
        {
            int earnedPoints = (int)Math.Ceiling(CalculateTotalCost(items) * 0.10);
            Points += earnedPoints;
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
                totalCost += item.Cost;
            }
            return totalCost;
        }
    }
}
