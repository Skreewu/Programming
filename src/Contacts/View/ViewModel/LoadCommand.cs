using System.Windows.Input;
using View.Model.Services;
using View.Model;

namespace View.ViewModel
{
    /// <summary>
    /// Команда для загрузки данных из файла.
    /// </summary>
    class LoadCommand : ICommand
    {
        /// <summary>
        /// Сериализатор.
        /// </summary>
        private readonly ContactSerializer _contactSerializer;
        private readonly MainVM _viewModel;

        /// <summary>
        /// Создает экземпляр класса <see cref="LoadCommand"/>
        /// </summary>
        /// <param name="contactSerializer"></param>
        /// <param name="viewModel"></param>
        public LoadCommand(ContactSerializer contactSerializer, MainVM viewModel)
        {
            _contactSerializer = contactSerializer;
            _viewModel = viewModel;
        }
        /// <summary>
        /// Событие изменения возможности выполнения команды.
        /// </summary>
        public event EventHandler CanExecuteChanged;

        /// <summary>
        /// Возвращает возможность выполения команды.
        /// </summary>
        /// <param name="parameter">Параметр.</param>
        /// <returns></returns>
        public bool CanExecute(object parameter) => true;

        /// <summary>
        /// Загружает из файла.
        /// </summary>
        /// <param name="parameter"></param>
        public void Execute(object parameter)
        {
            try
            {
                Contact contact = _contactSerializer.LoadFromFile();
                _viewModel.Name = contact.Name;
                _viewModel.PhoneNumber = contact.PhoneNumber;
                _viewModel.Email = contact.Email;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
