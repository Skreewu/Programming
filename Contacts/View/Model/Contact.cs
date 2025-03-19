using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Model
{
    /// <summary>
    /// Хранит данные о контакте.
    /// </summary>
    internal class Contact
    {
        /// <summary>
        /// Имя.
        /// </summary>
        private string _name;
        /// <summary>
        /// Номер телефона.
        /// </summary>
        private string _phoneNumber;
        /// <summary>
        /// Электронная почта.
        /// </summary>
        private string _email;

        /// <summary>
        /// Задает и возвращает имя.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
            }
        }
        /// <summary>
        /// Задает и возвращает номер телефона.
        /// </summary>
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                _phoneNumber = value;
            }
        }
        /// <summary>
        /// Задает и возвращает электронную почту.
        /// </summary>
        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
            }
        }
        /// <summary>
        /// Создает объект класса <see cref="Contact"/>
        /// </summary>
        /// <param name="name">Имя.</param>
        /// <param name="phoneNumber">Номер телефона.</param>
        /// <param name="email">Электронная почта.</param>
        public Contact(string name, string phoneNumber, string email)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
        }
        /// <summary>
        /// Конструктор по умолчанию. Создает объект класса <see cref="Contact"
        /// </summary>
        public Contact()
        {

        }
    }
}
