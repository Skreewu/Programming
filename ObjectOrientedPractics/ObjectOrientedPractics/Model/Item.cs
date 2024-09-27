using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о товаре.
    /// </summary>
    internal class Item
    {
        /// <summary>
        /// Переменная, генерирующая id товара.
        /// </summary>
        private static int idGeneration = 0;
        /// <summary>
        /// id товара.
        /// </summary>
        private readonly int _id;
        /// <summary>
        /// Название товара.
        /// </summary>
        private string _name;
        /// <summary>
        /// Информация о товаре.
        /// </summary>
        private string _info;
        /// <summary>
        /// Стоимость.
        /// </summary>
        private double _cost;

        /// <summary>
        /// Задает и возвращает данные о названии товара. Не больше 200 символов.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 200, nameof(Name));
                _name = value;
            }
        }
        /// <summary>
        /// Задает и возвращает информацию о товаре. Не больше 1000 символов.
        /// </summary>
        public string Info
        {
            get { return _info; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 1000, nameof(Name));
                _info = value;
            }
        }
        /// <summary>
        /// Задает и возвращает стоимость товара. От 0 до 100 000.
        /// </summary>
        public double Cost
        {
            get { return _cost; }
            set
            {
                ValueValidator.AssertValueInRange(value, 0, 100000, nameof(Cost));
                _cost = value;
            }
        }
        /// <summary>
        /// Создаёт экземпляр класса <see cref="Item"/>.
        /// </summary>
        /// <param name="name">Название товара. Не больше 200 символов.</param>
        /// <param name="info">Инфорация о товаре. Не больше 1000 символов.</param>
        /// <param name="cost">Стоимость. От 0 до 100 000.</param>
        public Item(string name, string info, double cost)
        {
            _id = idGeneration;
            Name = name;
            Info = info;
            Cost = cost;
            idGeneration++;
        }
    }
}
