using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;
using View.Model;
using View.Model.Services;

namespace View.ViewModel
{
    /// <summary>
    /// ViewModel основного окна.
    /// </summary>
    internal class MainVM : INotifyPropertyChanged
    {
        /// <summary>
        /// Сериализатор.
        /// </summary>
        private readonly ContactSerializer _contactSerializer;

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
        /// Создает объект класса <see cref="MainVM"/>
        /// </summary>
        public MainVM()
        {
            _contactSerializer = new ContactSerializer();
            Contacts = _contactSerializer.Load();

            AddCommand = new RelayCommand(
                execute: ExecuteAddCommand,
                canExecute: _ => true
            );

            EditCommand = new RelayCommand(
                execute: ExecuteEditCommand,
                canExecute: _ => SelectedContact != null && Contacts.Count > 0,
                useCommandManager: true
            );

            RemoveCommand = new RelayCommand(
                execute: ExecuteRemoveCommand,
                canExecute: _ => SelectedContact != null && Contacts.Count > 0,
                useCommandManager: true
            );

            ApplyCommand = new RelayCommand(
                execute: ExecuteApplyCommand,
                canExecute: _ => IsEditOrAdd &&
                       !string.IsNullOrWhiteSpace(TempContact?.Name) &&
                       !string.IsNullOrWhiteSpace(TempContact?.PhoneNumber) &&
                       !string.IsNullOrWhiteSpace(TempContact?.Email),
                useCommandManager: true
            );

            SaveInFileCommand = new RelayCommand(
                execute: ExecuteSaveInFileCommand,
                canExecute: _ => true
            );
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
        /// Команда для сохранения коллекции элементов в файл.
        /// </summary>
        public ICommand SaveInFileCommand { get; }

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
                OnPropertyChanged(nameof(TempContact));
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
        public bool Visible
        {
            get { return _isEditOrAdd; }
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
        /// Метод для комманды добавления.
        /// </summary>
        /// <param name="parameter"></param>
        private void ExecuteAddCommand(object parameter)
        {
            IsEditOrAdd = true;
            TempContact = new Contact();
            SelectedContact = null;
            OnPropertyChanged(nameof(IsReadOnly));
            OnPropertyChanged(nameof(Visible));
        }

        /// <summary>
        /// Метод для комманды редактирования.
        /// </summary>
        /// <param name="parameter"></param>
        private void ExecuteEditCommand(object parameter)
        {
            IsEditOrAdd = true;
            TempContact = new Contact(SelectedContact.Name, SelectedContact.PhoneNumber, SelectedContact.Email);
            OnPropertyChanged(nameof(IsReadOnly));
            OnPropertyChanged(nameof(Visible));
        }

        /// <summary>
        /// Метод для команды удаления.
        /// </summary>
        /// <param name="parameter"></param>
        private void ExecuteRemoveCommand(object parameter)
        {
            int index = Contacts.IndexOf(SelectedContact);
            Contacts.Remove(SelectedContact);

            if (Contacts.Count > 0)
            {
                if (index >= Contacts.Count)
                {
                    index = Contacts.Count - 1;
                }
                SelectedContact = Contacts[index];
            }
            else
            {
                SelectedContact = null;
            }

            OnPropertyChanged(nameof(IsEnabled));
        }

        /// <summary>
        /// Метод для комманды подтверждения.
        /// </summary>
        /// <param name="parameter"></param>
        private void ExecuteApplyCommand(object parameter)
        {
            if (SelectedContact == null)
            {
                var newContact = new Contact(TempContact.Name, TempContact.PhoneNumber, TempContact.Email);
                Contacts.Add(newContact);
                SelectedContact = newContact;
            }
            else
            {
                SelectedContact.Name = TempContact.Name;
                SelectedContact.PhoneNumber = TempContact.PhoneNumber;
                SelectedContact.Email = TempContact.Email;
            }

            IsEditOrAdd = false;
            TempContact = null;
            OnPropertyChanged(nameof(IsReadOnly));
            OnPropertyChanged(nameof(Visible));
        }

        /// <summary>
        /// Метод для комманды сохранения и загрузки в файл.
        /// </summary>
        /// <param name="parameter"></param>
        private void ExecuteSaveInFileCommand(object parameter)
        {
            _contactSerializer.Save(Contacts);
        }

        /// <summary>
        /// Уведомляет об изменении свойства с помощью события <see cref="PropertyChanged"/>
        /// </summary>
        /// <param name="propertyName">Название измененного свойства.</param>
        public virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
