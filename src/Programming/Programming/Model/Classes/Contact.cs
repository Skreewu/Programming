using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о контакте в телефонной книге.
    /// </summary>
    internal class Contact
    {
        /// <summary>
        /// Имя контакта.
        /// </summary>
        public string _name;
        /// <summary>
        /// Фамилия контакта.
        /// </summary>
        private string _surname;
        /// <summary>
        /// Номер телефона.
        /// </summary>
        private string _phoneNumber;

        /// <summary>
        /// Возвращает и задает имя контакта. Может содержать только буквы английского алфавита.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("Value cannot be empty");
                }
                if (AssertStringContainsOnlyLetters(value) == false)
                {
                    throw new ArgumentException("Name should consist only of letters of the English alphabet");
                }
                _name = value;
            }
        }
        /// <summary>
        /// Возвращает и задает номер телефона.
        /// </summary>
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("Value cannot be empty");
                }
                _phoneNumber = value;
            }
        }
        /// <summary>
        /// Возвращает и задает фамилию контакта. Может содержать только буквы английского алфавита.
        /// </summary>
        public string Surname
        {
            get { return _surname; }
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("Value cannot be empty");
                }
                if (AssertStringContainsOnlyLetters(value) == false)
                {
                    throw new ArgumentException("Surname should consist only of letters of the English alphabet");
                }
                _surname = value;
            }
        }
        /// <summary>
        /// Создаёт экземпляр класса <see cref="Contact"/>.
        /// </summary>
        /// <param name="contactname">Имя контакта. Может содержать только буквы английского алфавита.</param>
        /// <param name="surname">Фамилия контакта. Может содержать только буквы английского алфавита.</param>
        /// <param name="phoneNumber">Номер телефона.</param>
        public Contact(string contactname, string surname, string phoneNumber)
        {
            Name = contactname;
            Surname = surname;
            PhoneNumber = phoneNumber;
        }
        public Contact()
        {
            Name = "Alex";
            Surname = "Petrov";
            PhoneNumber = "89637009911";
        }
        /// <summary>
        /// Проверяет, что строка состоит только из букв английского алфавита.
        /// </summary>
        /// <param name="value">Проверяемая строка.</param>
        /// <returns>Возвращает true, если строка состоит из букв английского алфавита. И false, если есть хотя бы одна не буква.</returns>
        private bool AssertStringContainsOnlyLetters(string value)
        {
            value.ToLower();
            foreach (char c in value)
            {
                if (c >= 'a' && c <= 'z')
                {
                    return true;
                }
            }
            return false;
        }
    }
}
