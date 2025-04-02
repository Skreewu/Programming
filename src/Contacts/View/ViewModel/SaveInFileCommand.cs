using System.Collections.ObjectModel;
using System.Windows.Input;
using View.Model;
using View.Model.Services;

namespace View.ViewModel
{
    /// <summary>
    /// Команда для сохранения коллекции контакта.
    /// </summary>
    internal class SaveInFileCommand : ICommand
    {
        /// <summary>
        /// Список контактов для сохранения
        /// </summary>
        private readonly ObservableCollection<Contact> _contacts;

        /// <summary>
        /// Сериализатор.
        /// </summary>
        private readonly ContactSerializer _contactSerializer;

        /// <summary>
        /// Создает экземпляр класса <see cref="SaveInFileCommand"/>
        /// </summary>
        /// <param name="contactSerializer"></param>
        /// <param name="viewModel"></param>
        public SaveInFileCommand(ContactSerializer contactSerializer, ObservableCollection<Contact> contacts)
        {
            _contactSerializer = contactSerializer;
            _contacts = contacts;
        }

        /// <summary>
        /// Событие изменения возможности выполнения команды.
        /// </summary>
        public event EventHandler? CanExecuteChanged;

        /// <summary>
        /// Возвращает возможность выполения команды.
        /// </summary>
        /// <param name="parameter">Параметр.</param>
        /// <returns></returns>
        public bool CanExecute(object? parameter) => true;

        /// <summary>
        /// Создает объект.
        /// </summary>
        /// <param name="parameter"></param>
        public void Execute(object? parameter)
        {
            _contactSerializer.Save(_contacts);
        }
    }
}
