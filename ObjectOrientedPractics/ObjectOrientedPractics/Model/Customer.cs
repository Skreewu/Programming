using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит информацию о покупателе.
    /// </summary>
    internal class Customer
    {
        /// <summary>
        /// Переменная, генерирующая id товара.
        /// </summary>
        private static int idGeneration;
        /// <summary>
        /// id товара.
        /// </summary>
        private readonly int _id;
        /// <summary>
        /// Имя и фамилия покупателя.
        /// </summary>
        private string _fullname;
        /// <summary>
        /// Адрес покупателя.
        /// </summary>
        private string _address;

        /// <summary>
        /// Задает и возвращает имя и фамилию покупателя. Не больше 200 символов.
        /// </summary>
        public string FullName
        {
            get { return _fullname; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 200, nameof(FullName));
                _fullname = value;
            }
        }
        /// <summary>
        /// Задает и возвращает адремм покупателя. Не больше 500 символов.
        /// </summary>
        public string Address
        {
            get { return _address; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 500, nameof(Address));
                _address = value;
            }
        }
        /// <summary>
        /// Создает экземпляр класса <see cref="Customer">
        /// </summary>
        /// <param name="fullname">Имя и фамилия покупателя. Не больше 200 символов. </param>
        /// <param name="address">Адресс покупателя. Не больше 500 символов</param>
        public Customer(string fullname, string address)
        {
            _id = idGeneration;
            _fullname = fullname;
            Address = address;
            idGeneration++;
        }
    }
}
