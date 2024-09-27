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
        private static int idGeneration = -1;
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
        /// Возвращает id покупателя
        /// </summary>
        public int ID
        {
            get { return _id; }
        }
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
            FullName = fullname;
            Address = address;
            idGeneration++;
        }
        /// <summary>
        /// Конструктор по умолчанию. Создает экзепляр класса <see cref="Customer"/>
        /// </summary>
        public Customer()
        {
            _id = idGeneration;
            FullName = "Фамилия Имя";
            Address = "Адрес";
            idGeneration++;
        }
        /// <summary>
        /// Предоставляет экземпляр класса в более удобной форме.
        /// </summary>
        /// <returns>Возвращает преобразование в строку</returns>
        public override string ToString()
        {
            return FullName;
        }
    }
}
