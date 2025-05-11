using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using View.Model;
using View.Model.Services;

namespace View.ViewModel
{
    /// <summary>
    /// ViewModel основного окна.
    /// </summary>
    internal partial class MainVM : ObservableObject
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
        private bool _isEditOrAdd;

        /// <summary>
        /// Выбранный в списке контакт.
        /// </summary>
        [ObservableProperty]
        private Contact _selectedContact;

        /// <summary>
        /// Активный контакт.
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
        /// Задает и возвращает выбранный контакт.
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
            EditCommand.NotifyCanExecuteChanged();
            RemoveCommand.NotifyCanExecuteChanged();
        }

        /// <summary>
        /// Команда добавления.
        /// </summary>
        [RelayCommand]
        private void Add()
        {
            IsEditOrAdd = true;
            ActiveContact = new Contact();
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

        private bool CanEdit() => SelectedContact != null && Contacts.Count > 0;

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

        private bool CanRemove() => SelectedContact != null && Contacts.Count > 0;

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

        private bool CanApply() => IsEditOrAdd &&
            string.IsNullOrEmpty(ActiveContact[nameof(Contact.Name)]) &&
            string.IsNullOrEmpty(ActiveContact[nameof(Contact.PhoneNumber)]) &&
            string.IsNullOrEmpty(ActiveContact[nameof(Contact.Email)]);

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
