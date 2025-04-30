using System.Collections.ObjectModel;
using System.ComponentModel;
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
                       string.IsNullOrEmpty(CurrentContact[nameof(Contact.Name)]) &&
                       string.IsNullOrEmpty(CurrentContact[nameof(Contact.PhoneNumber)]) &&
                       string.IsNullOrEmpty(CurrentContact[nameof(Contact.Email)]),
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
        /// Задает и возвращает активный контакт.
        /// </summary>
        public Contact CurrentContact
        {
            get => _isEditOrAdd ? _tempContact : SelectedContact;
            set
            {
                if (_isEditOrAdd)
                {
                    _tempContact = value;
                }
                else
                {
                    SelectedContact = value;
                }
                OnPropertyChanged(nameof(CurrentContact));
            }
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
                        _tempContact = null;
                    }

                    OnPropertyChanged(nameof(SelectedContact));
                    OnPropertyChanged(nameof(IsEnabled));
                    OnPropertyChanged(nameof(CurrentContact));
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
            _tempContact = new Contact();
            CurrentContact = _tempContact;
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
            _tempContact = new Contact(SelectedContact);
            CurrentContact = _tempContact;
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
                var newContact = new Contact(_tempContact);
                Contacts.Add(newContact);
                SelectedContact = newContact;
            }
            else
            {
                SelectedContact.Name = _tempContact.Name;
                SelectedContact.PhoneNumber = _tempContact.PhoneNumber;
                SelectedContact.Email = _tempContact.Email;
            }

            IsEditOrAdd = false;
            _tempContact = null;
            OnPropertyChanged(nameof(IsReadOnly));
            OnPropertyChanged(nameof(Visible));
            OnPropertyChanged(nameof(CurrentContact));
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
            CommandManager.InvalidateRequerySuggested();
        }
    }
}
