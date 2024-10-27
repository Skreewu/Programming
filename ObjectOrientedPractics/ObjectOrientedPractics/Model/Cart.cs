using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит корзину товаров пользователя.
    /// </summary>
    [DataContract]
    internal class Cart
    {
        /// <summary>
        /// Список товаров.
        /// </summary>
        private List<Item> _items;
        /// <summary>
        /// Общая стоимость товаров.
        /// </summary>
        private double _amount;

        /// <summary>
        /// Задает и возвращает список товаров.
        /// </summary>
        [DataMember]
        public List<Item> Items
        {
            get { return _items; }
            set { _items = value; }
        }
        /// <summary>
        /// Возвращает общую стоимость товаров.
        /// </summary>
        public double Amount
        {
            get
            {
                _amount = 0;
                if (_items == null || _items.Count == 0) return 0;
                for (int i = 0; i < _items.Count; i++)
                {
                    _amount += _items[i].Cost;
                }
                return _amount;
            }
        }
        /// <summary>
        /// Создает экземпляр классса <see cref="Cart"/>
        /// </summary>
        public Cart()
        {
            Items = new List<Item>();
        }
    }
}
