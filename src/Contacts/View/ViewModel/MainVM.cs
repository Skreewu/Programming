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
    internal class MainVM : INotifyPropertyChanged, IDisposable
    {
        /// <summary>
        /// Режим редактирования или добавления.
        /// </summary>
        private bool _isEditOrAdd;

        /// <summary>
        /// Выбранный контакт.
        /// </summary>
        private Contact _selectedContact;

        /// <summary>
        /// Временный контакт для редактирования.
        /// </summary>
        private Contact _tempContact;

        /// <summary>
        /// Сериализатор.
        /// </summary>
        private readonly ContactSerializer _contactSerializer;

        /// <summary>
        /// Создает объект класса <see cref="MainVM"/>
        /// </summary>
        public MainVM()
        {
            _contactSerializer = new ContactSerializer();
            Contacts = _contactSerializer.Load();
            AddCommand = new AddCommand(this);
            EditCommand = new EditCommand(this);
            RemoveCommand = new RemoveCommand(this);
            ApplyCommand = new ApplyCommand(this);
        }

        /// <summary>
        /// Событие, возникающее при изменении значения свойства.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Команда добавления.
        /// </summary>
        public ICommand AddCommand { get; }

        /// <summary>
        /// Команда редактирования.
        /// </summary>
        public ICommand EditCommand { get; }

        /// <summary>
        /// Команда удаления.
        /// </summary>
        public ICommand RemoveCommand { get; }

        /// <summary>
        /// Команда подтверждения.
        /// </summary>
        public ICommand ApplyCommand { get; }

        /// <summary>
        /// Список контактов.
        /// </summary>
        public ObservableCollection<Contact> Contacts { get; }

        /// <summary>
        /// Задает и возвращает режим редактирования
        /// </summary>
        public bool IsEditOrAdd
        {
            get => _isEditOrAdd;
            set
            {
                if (_isEditOrAdd != value)
                {
                    _isEditOrAdd = value;
                    OnPropertyChanged(nameof(IsReadOnly));
                    OnPropertyChanged(nameof(Visible));
                }
            }
        }

        /// <summary>
        /// Задает и возвращает временный контакт.
        /// </summary>
        public Contact TempContact
        {
            get => _tempContact;
            set
            {
                _tempContact = value;
                OnPropertyChanged(nameof(Name));
                OnPropertyChanged(nameof(PhoneNumber));
                OnPropertyChanged(nameof(Email));
            }
        }

        /// <summary>
        /// Возвращает свойство только для чтения.
        /// </summary>
        public bool IsReadOnly
        {
            get { return !_isEditOrAdd; }
        }

        /// <summary>
        /// Возвращает свойство доступности объекта.
        /// </summary>
        public bool IsEnabled
        {
            get { return _selectedContact != null && Contacts.Count > 0; }
        }

        /// <summary>
        /// Возвращает видимость.
        /// </summary>
        public Visibility Visible
        {
            get { return _isEditOrAdd ? Visibility.Visible : Visibility.Collapsed; }
        }

        /// <summary>
        /// Задает и возвращает выбранный контакт.
        /// </summary>
        public Contact SelectedContact
        {
            get => _selectedContact;
            set
            {
                if (_selectedContact != value)
                {
                    _selectedContact = value;

                    if (IsEditOrAdd && value != null)
                    {
                        IsEditOrAdd = false;
                        TempContact = null;
                    }

                    OnPropertyChanged(nameof(SelectedContact));
                    OnPropertyChanged(nameof(Name));
                    OnPropertyChanged(nameof(PhoneNumber));
                    OnPropertyChanged(nameof(Email));
                    OnPropertyChanged(nameof(IsEnabled));
                }
            }
        }

        /// <summary>
        /// Задает и возвращает имя контакта.
        /// </summary>
        public string Name
        {
            get => IsEditOrAdd ? TempContact?.Name : SelectedContact?.Name;
            set
            {
                if (IsEditOrAdd)
                {
                    if (TempContact != null && TempContact.Name != value)
                    {
                        TempContact.Name = value;
                        OnPropertyChanged(nameof(Name));
                        CommandManager.InvalidateRequerySuggested();
                    }
                }
                else if (SelectedContact != null && SelectedContact.Name != value)
                {
                    SelectedContact.Name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }

        /// <summary>
        /// Задает и возвращает номер контакта.
        /// </summary>
        public string PhoneNumber
        {
            get => IsEditOrAdd ? TempContact?.PhoneNumber : SelectedContact?.PhoneNumber;
            set
            {
                if (IsEditOrAdd)
                {
                    if (TempContact != null && TempContact.PhoneNumber != value)
                    {
                        TempContact.PhoneNumber = value;
                        OnPropertyChanged(nameof(PhoneNumber));
                        CommandManager.InvalidateRequerySuggested();
                    }
                }
                else if (SelectedContact != null && SelectedContact.PhoneNumber != value)
                {
                    SelectedContact.PhoneNumber = value;
                    OnPropertyChanged(nameof(PhoneNumber));
                }
            }
        }

        /// <summary>
        /// Задает и возвращает почту контакта.
        /// </summary>
        public string Email
        {
            get => IsEditOrAdd ? TempContact?.Email : SelectedContact?.Email;
            set
            {
                if (IsEditOrAdd)
                {
                    if (TempContact != null && TempContact.Email != value)
                    {
                        TempContact.Email = value;
                        OnPropertyChanged(nameof(Email));
                        CommandManager.InvalidateRequerySuggested();
                    }
                }
                else if (SelectedContact != null && SelectedContact.Email != value)
                {
                    SelectedContact.Email = value;
                    OnPropertyChanged(nameof(Email));
                }
            }
        }
        
        /// <summary>
        /// Уведомляет об изменении свойства с помощью события <see cref="PropertyChanged"/>
        /// </summary>
        /// <param name="propertyName">Название измененного свойства.</param>
        public virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void Dispose()
        {
            _contactSerializer.Save(Contacts);
        }
    }
}
