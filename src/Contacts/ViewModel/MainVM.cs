using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using Model;
using Model.Services;

namespace ViewModel
{
    /// <summary>
    /// ViewModel основного окна.
    /// </summary>
    public partial class MainVM : ObservableObject
    {
        /// <summary>
        /// Сериализатор.
        /// </summary>
        private readonly ContactSerializer _contactSerializer;

        /// <summary>
        /// Режим редактирования или добавления.
        /// </summary>
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(IsReadOnly))]
        [NotifyPropertyChangedFor(nameof(Visible))]
        [NotifyPropertyChangedFor(nameof(IsEnabled))]
        [NotifyCanExecuteChangedFor(nameof(ApplyCommand))]
        private bool _isEditOrAdd;

        /// <summary>
        /// Выбранный в списке контакт.
        /// </summary>
        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(EditCommand))]
        [NotifyCanExecuteChangedFor(nameof(RemoveCommand))]
        private Contact _selectedContact;

        /// <summary>
        /// Активный контакт, с которым происходит взаимодействие.
        /// </summary>
        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(ApplyCommand))]
        private Contact _activeContact;

        /// <summary>
        /// Создает объект класса <see cref="MainVM"/>
        /// </summary>
        public MainVM()
        {
            _contactSerializer = new ContactSerializer();
            _activeContact = new Contact();
            Contacts = _contactSerializer.Load();
            if (_activeContact != null)
            {
                _activeContact.PropertyChanged += (s, e) => ApplyCommand.NotifyCanExecuteChanged();
            }
        }

        /// <summary>
        /// Список контактов.
        /// </summary>
        public ObservableCollection<Contact> Contacts { get; }

        /// <summary>
        /// Возвращает свойство только для чтения.
        /// </summary>
        public bool IsReadOnly => !IsEditOrAdd;

        /// <summary>
        /// Возвращает видимость.
        /// </summary>
        public bool Visible => IsEditOrAdd;

        /// <summary>
        /// Возвращает, включены ли кнопки.
        /// </summary>
        public bool IsEnabled => !IsEditOrAdd;

        /// <summary>
        /// Осуществляет выбор контакта.
        /// </summary>
        partial void OnSelectedContactChanged(Contact value)
        {
            if (value != null)
            {
                if (IsEditOrAdd)
                {
                    IsEditOrAdd = false;
                }
                ActiveContact.Name = value.Name;
                ActiveContact.PhoneNumber = value.PhoneNumber;
                ActiveContact.Email = value.Email;
            }
        }

        /// <summary>
        /// Команда добавления.
        /// </summary>
        [RelayCommand]
        private void Add()
        {
            IsEditOrAdd = true;
            ActiveContact = new Contact();
            ActiveContact.PropertyChanged += (s, e) => ApplyCommand.NotifyCanExecuteChanged();
            SelectedContact = null;
        }

        /// <summary>
        /// Команда редактирования.
        /// </summary>
        [RelayCommand(CanExecute = nameof(CanEdit))]
        private void Edit()
        {
            IsEditOrAdd = true;
        }

        /// <summary>
        /// Возвращает возможность редактирования.
        /// </summary>
        private bool CanEdit => SelectedContact != null && Contacts.Count > 0;

        /// <summary>
        /// Команда удаления.
        /// </summary>
        [RelayCommand(CanExecute = nameof(CanRemove))]
        private void Remove()
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
                ActiveContact = null;
            }
        }

        /// <summary>
        /// Возвращает возможность удаления.
        /// </summary>
        private bool CanRemove => SelectedContact != null && Contacts.Count > 0;

        /// <summary>
        /// Команда подтверждения.
        /// </summary>
        [RelayCommand(CanExecute = nameof(CanApply))]
        private void Apply()
        {
            if (SelectedContact == null)
            {
                var newContact = new Contact(ActiveContact);
                Contacts.Add(newContact);
                SelectedContact = newContact;
            }
            else
            {
                SelectedContact.Name = ActiveContact.Name;
                SelectedContact.PhoneNumber = ActiveContact.PhoneNumber;
                SelectedContact.Email = ActiveContact.Email;
            }

            IsEditOrAdd = false;
        }

        /// <summary>
        /// Возвращает возможность применения изменений.
        /// </summary>
        private bool CanApply => IsEditOrAdd &&
            !string.IsNullOrEmpty(ActiveContact?.Name) &&
            string.IsNullOrEmpty(ActiveContact?[nameof(Contact.Name)]) &&
            string.IsNullOrEmpty(ActiveContact?[nameof(Contact.PhoneNumber)]) &&
            string.IsNullOrEmpty(ActiveContact?[nameof(Contact.Email)]);

        /// <summary>
        /// Команда сохранения и загрузки в файл.
        /// </summary>
        /// <param name="parameter"></param>
        [RelayCommand]
        private void SaveInFile(object parameter)
        {
            _contactSerializer.Save(Contacts);
        }
    }
}
