using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    class Store
    {
        /// <summary>
        /// Список объектов класса Item
        /// </summary>
        private List<Item> _items;
        /// <summary>
        /// Список объектов класса Customer
        /// </summary>
        private List<Customer> _customers;

        /// <summary>
        /// Задает и возвращает список объектов класса Item
        /// </summary>
        public List<Item> Items
        {
            get { return _items; }
            set
            {
                _items = value;
            }
        }
        /// <summary>
        /// Задает и возвращает список объектов класса Customer
        /// </summary>
        public List<Customer> Customers
        {
            get { return _customers; }
            set
            {
                _customers = value;
            }
        }
        /// <summary>
        /// Конструктор по умолчанию. Создает экземпляр класса <see cref="Store"/>
        /// </summary>
        public Store()
        {
            List<Item> Item = new List<Item>();
            List<Customer> Customers = new List<Customer>();
        }
    }
}
