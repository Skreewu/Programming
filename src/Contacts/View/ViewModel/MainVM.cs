using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using View.Model;
using View.Model.Services;

namespace View.ViewModel
{
    /// <summary>
    /// ViewModel.
    /// </summary>
    internal class MainVM
    {
        /// <summary>
        /// Список контактов.
        /// </summary>
        public ObservableCollection<Contact> Contacts { get; } = new ObservableCollection<Contact>
        {
            new Contact("Алексей", "89235678902", "Alexey@gmail.com"),
            new Contact("Мария", "89832613523", "Maria@mail.ru")
        };

        /// <summary>
        /// Выбранный контакт.
        /// </summary>
        private Contact _contact;

        /// <summary>
        /// Сериализатор.
        /// </summary>
        private readonly ContactSerializer _contactSerializer;

        /// <summary>
        /// Команда для сохранения в файл.
        /// </summary>
        public ICommand SaveCommand { get; }

        /// <summary>
        /// Команда для загрузки из файла.
        /// </summary>
        public ICommand LoadCommand { get; }

        /// <summary>
        /// Создает объект класса <see cref="MainVM"/>
        /// </summary>
        public MainVM()
        {
            _contact = new Contact();
            _contactSerializer = new ContactSerializer();
            SaveCommand = new SaveCommand(_contactSerializer, _contact);
            LoadCommand = new LoadCommand(_contactSerializer, this);
        }

        /// <summary>
        /// Задает и возвращает имя контакта.
        /// </summary>
        public string Name
        {
            get { return _contact.Name; }
            set
            {
                if (_contact.Name != value)
                {
                    _contact.Name = value;
                }
            }
        }

        /// <summary>
        /// Задает и возвращает номер контакта.
        /// </summary>
        public string PhoneNumber
        {
            get { return _contact.PhoneNumber; }
            set
            {
                if (_contact.PhoneNumber != value)
                {
                    _contact.PhoneNumber = value;
                }
            }
        }

        /// <summary>
        /// Задает и возвращает почту контакта.
        /// </summary>
        public string Email
        {
            get { return _contact.Email; }
            set
            {
                if (_contact.Email != value)
                {
                    _contact.Email = value;
                }
            }
        }
    }
}
