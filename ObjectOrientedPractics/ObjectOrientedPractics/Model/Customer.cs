using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит информацию о покупателе.
    /// </summary>
    [DataContract]
    internal class Customer
    {
        /// <summary>
        /// Переменная, генерирующая id товара.
        /// </summary>
        private static int _idGeneration = -1;
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
        [DataMember]
        public int ID
        {
            get { return _id; }
        }
        /// <summary>
        /// Задает и возвращает имя и фамилию покупателя. Не больше 200 символов.
        /// </summary>
        [DataMember]
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
        [DataMember]
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
            _id = _idGeneration;
            FullName = fullname;
            Address = address;
            _idGeneration++;
        }
        /// <summary>
        /// Конструктор по умолчанию. Создает экзепляр класса <see cref="Customer"/>
        /// </summary>
        public Customer()
        {
            _id = _idGeneration;
            FullName = "Фамилия Имя";
            Address = "Адрес";
            _idGeneration++;
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
