using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Интерфейс для представления скидки.
    /// </summary>
    internal interface IDiscount
    {
        /// <summary>
        /// Получает информацию о скидке.
        /// </summary>
        string Info { get; }

        /// <summary>
        /// Вычисляет общую сумму скидки для заданного списка товаров.
        /// </summary>
        /// <param name="items">Список товаров, на которые применяется скидка.</param>
        /// <returns>Сумма скидки.</returns>
        double Calculate(List<Item> items);

        /// <summary>
        /// Применяет скидку к заданному списку товаров и возвращает общую сумму, на которую была предоставлена скидка.
        /// </summary>
        /// <param name="items">Список товаров, к которым применяется скидка.</param>
        /// <returns>Сумма, на которую была предоставлена скидка.</returns>
        double Apply(List<Item> items);

        /// <summary>
        /// Обновляет состояние скидки на основе заданного списка товаров.
        /// </summary>
        /// <param name="items">Список товаров для обновления состояния скидки.</param>
        void Update(List<Item> items);
    }
}
