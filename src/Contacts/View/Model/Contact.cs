using CommunityToolkit.Mvvm.ComponentModel;
using System.ComponentModel;

namespace View.Model
{
    /// <summary>
    /// Хранит данные о контакте.
    /// </summary>
    public partial class Contact : ObservableObject, IDataErrorInfo
    {
        /// <summary>
        /// Имя.
        /// </summary>
        [ObservableProperty]
        private string _name;

        /// <summary>
        /// Номер телефона.
        /// </summary>
        [ObservableProperty]
        private string _phoneNumber;

        /// <summary>
        /// Электронная почта.
        /// </summary>
        [ObservableProperty]
        private string _email;

        /// <summary>
        /// Создает экземпляр класса <see cref="Contact"/>
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
        /// Конструктор копирования. Создает объект класса <see cref="Contact"./>
        /// </summary>
        /// <param name="contact">Контакт для копирования.</param>
        public Contact(Contact contact)
        {
            Name = contact.Name;
            PhoneNumber = contact.PhoneNumber;
            Email = contact.Email;
        }

        /// <summary>
        /// Создает объект класса <see cref="Contact"
        /// </summary>
        public Contact() { }

        /// <summary>
        /// Возвращает проверку всего объекта на ошибки.
        /// </summary>
        public string Error => null; 

        /// <summary>
        /// Возвращает проверку отдельного свойства на ошибки.
        /// </summary>
        /// <param name="columnName">Свойство для проверки.</param>
        /// <returns>Возвращает ошибку.</returns>
        public string this[string columnName]
        {
            get
            {
                string error = string.Empty;

                switch (columnName)
                {
                    case nameof(Name):
                        if (Name != null)
                        {
                            if (Name.Length > 100)
                            {
                                error = "Name cannot be longer than 100 characters";
                            }
                        }
                        break;

                    case nameof(PhoneNumber):
                        if (PhoneNumber != null)
                        {
                            if (PhoneNumber.Length > 100)
                            {
                                error = "Phone number cannot be longer than 100 characters";
                            }
                            else if (!System.Text.RegularExpressions.Regex.IsMatch(PhoneNumber, @"^[\d\+\-\(\)\s]+$"))
                            {
                                error = "Phone number can only contain digits or +-() characters";
                            }
                        }
                        break;

                    case nameof(Email):
                        if (Email != null)
                        {
                            if (Email.Length > 100)
                            {
                                error = "Email cannot be longer than 100 characters";
                            }
                            else if (!Email.Contains("@"))
                            {
                                error = "Email must contain @ symbol";
                            }
                        }
                        break;
                }

                return error;
            }
        }
    }
}
