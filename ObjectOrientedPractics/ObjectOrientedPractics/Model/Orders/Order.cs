using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Model.Discounts;

namespace ObjectOrientedPractics.Model.Orders
{
    /// <summary>
    /// Хранит данные о заказе пользователя.
    /// </summary>
    [DataContract]
    [KnownType(typeof(PriorityOrder))]
    internal class Order
    {
        private static IdGenerator idGenerator = new IdGenerator();
        /// <summary>
        /// ID заказа.
        /// </summary>
        [DataMember]
        public int Id { get; private set; }
        /// <summary>
        /// Возвращает дату создания заказа.
        /// </summary>
        [DataMember]
        public DateTime OrderCreationDate { get; private set; }
        /// <summary>
        /// Задает и возвращает статус заказа.
        /// </summary>  
        [DataMember]
        public OrderStatus Status { get; set; }
        /// <summary>
        /// Адрес доставки.
        /// </summary>
        private Address _address;
        /// <summary>
        /// Список товаров.
        /// </summary>
        private List<Item> _items;
        /// <summary>
        /// Общая стоимость товаров.
        /// </summary>
        private double _amount;
        /// <summary>
        /// Общая стоимость товаров с учетом скидки.
        /// </summary>
        private double _total;
        /// <summary>
        /// Задает и возвращает размер приминенной скидки.
        /// </summary>
        public double DiscountAmount { get; set; }

        /// <summary>
        /// Задает и возвращает конечную стоимость заказа.
        /// </summary>
        public double Total
        {
            get
            {
                if (Amount - DiscountAmount < 0)
                {
                    throw new ArgumentException("Value must be a positive number");
                }
                _total = Amount - DiscountAmount;
                return _total;
            }
        }
        /// <summary>
        /// Задает и возвращает адрес доставки.
        /// </summary>
        [DataMember]
        public Address Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
            }
        }
        /// <summary>
        /// Задает и возвращает список товаров.
        /// </summary>
        [DataMember]
        public List<Item> Items
        {
            get
            {
                return _items;
            }
            set
            {
                _items = value;
            }
        }
        /// <summary>
        /// Задает и возвращает общую стоимость товаров.
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
        /// Конструктор без параметров. Создает экземпляр класса <see cref="Order"/>
        /// </summary>
        public Order(bool isId)
        {
            if (isId)
            {
                Id = idGenerator.GetNextId();
            }
            OrderCreationDate = DateTime.Now;
            Items = new List<Item>();
            Address = new Address();
            Status = 0;
        }
        /// <summary>
        /// Создает экземпляр класса <see cref="Order"/>
        /// </summary>
        /// <param name="address">Адрес доставки.</param>
        /// <param name="items">Список товаров.</param>
        public Order(Address address, List<Item> items, bool isId)
        {
            if (isId)
            {
                Id = idGenerator.GetNextId();
            }
            OrderCreationDate = DateTime.Now;
            Items = items;
            Address = address;
            Status = 0;
        }
    }
}
