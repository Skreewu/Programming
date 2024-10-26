using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Reflection.Emit;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит информацию о покупателе.
    /// </summary>
    [DataContract]
    internal class Customer
    {
        private static IdGenerator idGenerator = new IdGenerator();
        /// <summary>
        /// Возвращает id покупателя
        /// </summary>
        [DataMember]
        public int Id { get; private set; }
        /// <summary>
        /// Имя и фамилия покупателя.
        /// </summary>
        private string _fullName;
        /// <summary>
        /// Адрес покупателя.
        /// </summary>
        private Address _address;
        /// <summary>
        /// Корзина покупателя.
        /// </summary>
        private Cart _cart;
        /// <summary>
        /// Список заказов покупателя.
        /// </summary>
        private List<Order> _orders;
        /// <summary>
        /// Задает и возвращает имя и фамилию покупателя. Не больше 200 символов.
        /// </summary>
        [DataMember]
        public string FullName
        {
            get { return _fullName; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 200, nameof(FullName));
                _fullName = value;
            }
        }
        /// <summary>
        /// Задает и возвращает корзину покупателя
        /// </summary>
        [DataMember]
        public Cart Cart
        {
            get 
            { 
                return _cart; 
            }
            set 
            { 
                _cart = value; 
            }
        }
        /// <summary>   
        /// Задает и возвращает адреса покупателя.
        /// </summary>
        [DataMember]
        public Address Address
        {
            get { return _address; }
            set
            {
                _address = value;
            }
        }
        /// <summary>
        /// Задает и возвращает список заказов покупателя
        /// </summary>
        [DataMember]
        public List<Order> Orders
        {
            get { return _orders; }
            set { _orders = value; }
        }
        /// <summary>
        /// Создает экземпляр класса <see cref="Customer">
        /// </summary>
        /// <param name="fullname">Имя и фамилия покупателя. Не больше 200 символов. </param>
        /// <param name="address">Адрес покупателя. Не больше 500 символов</param>
        public Customer(string fullname, Address address)
        {
            Id = idGenerator.GetNextId();
            FullName = fullname;
            Address = address;
        }
        /// <summary>
        /// Конструктор по умолчанию. Создает экзепляр класса <see cref="Customer"/>
        /// </summary>
        public Customer()
        {
            Id = idGenerator.GetNextId();
            FullName = "Фамилия Имя";
            Address = new Address();
            Cart = new Cart();
            Orders = new List<Order>();
        }
        /// <summary>
        /// Предоставляет экземпляр класса в более удобной форме.
        /// </summary>
        /// <returns>Возвращает преобразование в строку</returns>
        public override string ToString()
        {
            return FullName;
        }
        public static void SetId(int value)
        {
            idGenerator.SetId(value);
        }
    }
}
