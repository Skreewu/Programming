using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;
using View.Model;
using View.Model.Services;

namespace View.ViewModel
{
    /// <summary>
    /// ViewModel.
    /// </summary>
    internal class MainVM : INotifyPropertyChanged
    {
        private bool isEditOrAdd;

        /// <summary>
        /// Выбранный контакт.
        /// </summary>
        private Contact _selectedContact;

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
            isEditOrAdd = false;
            _contactSerializer = new ContactSerializer();
            SaveCommand = new SaveCommand(_contactSerializer, _selectedContact);
            LoadCommand = new LoadCommand(_contactSerializer, this);
        }
        public ObservableCollection<Contact> Contacts { get; } = new ObservableCollection<Contact> 
        {
            new Contact("Алексей", "89235678902", "Alexey@gmail.com"),
            new Contact("Мария", "89832613523", "Maria@mail.ru")
        };

        public bool IsReadOnly
        {
            get { return !isEditOrAdd; }
        }

        public bool IsEnabled
        {
            get { return _selectedContact != null && Contacts.Count > 0; }
        }

        public Visibility Visible
        {
            get { return isEditOrAdd ? Visibility.Visible : Visibility.Collapsed; }
        }

        public Contact SelectedContact
        {
            get { return _selectedContact; }
            set
            {
                _selectedContact = value;
                OnPropertyChanged(nameof(SelectedContact));
                OnPropertyChanged(nameof(Name));
                OnPropertyChanged(nameof(PhoneNumber));
                OnPropertyChanged(nameof(Email));
                OnPropertyChanged(nameof(IsEnabled));
            }
        }

        /// <summary>
        /// Задает и возвращает имя контакта.
        /// </summary>
        public string Name
        {
            get { return _selectedContact?.Name; }
            set
            {
                if (_selectedContact.Name != value)
                {
                    _selectedContact.Name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }

        /// <summary>
        /// Задает и возвращает номер контакта.
        /// </summary>
        public string PhoneNumber
        {
            get { return _selectedContact?.PhoneNumber; }
            set
            {
                if (_selectedContact.PhoneNumber != value)
                {
                    _selectedContact.PhoneNumber = value;
                    OnPropertyChanged(nameof(PhoneNumber));
                }
            }
        }

        /// <summary>
        /// Задает и возвращает почту контакта.
        /// </summary>
        public string Email
        {
            get { return _selectedContact?.Email; }
            set
            {
                if (_selectedContact.Email != value)
                {
                    _selectedContact.Email = value;
                    OnPropertyChanged(nameof(Email));
                }
            }
        }

        /// <summary>
        /// Событие, возникающее при изменении значения свойства.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Уведомляет об изменении свойства с помощью события <see cref="PropertyChanged"/>
        /// </summary>
        /// <param name="propertyName">Название измененного свойства.</param>
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
