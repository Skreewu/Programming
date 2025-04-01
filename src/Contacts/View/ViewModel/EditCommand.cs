using System.Windows.Input;
using View.Model;

namespace View.ViewModel
{
    internal class EditCommand : ICommand
    {
        /// <summary>
        /// Объект ViewModel.
        /// </summary>
        private readonly MainVM _viewModel;

        /// <summary>
        /// Создает экземпляр класса <see cref=""/>
        /// </summary>
        /// <param name="contactSerializer"></param>
        /// <param name="viewModel"></param>
        public EditCommand(MainVM viewModel)
        {
            _viewModel = viewModel;
        }

        /// <summary>
        /// Событие изменения возможности выполнения команды.
        /// </summary>
        public event EventHandler? CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        /// <summary>
        /// Возвращает возможность выполения команды.
        /// </summary>
        /// <param name="parameter">Параметр.</param>
        /// <returns></returns>
        public bool CanExecute(object? parameter)
        {
            return _viewModel.SelectedContact != null && _viewModel.Contacts.Count > 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="parameter"></param>
        public void Execute(object? parameter)
        {
            _viewModel.IsEditOrAdd = true;
            _viewModel.TempContact = new Contact(
                _viewModel.SelectedContact.Name,
                _viewModel.SelectedContact.PhoneNumber,
                _viewModel.SelectedContact.Email);
            _viewModel.OnPropertyChanged(nameof(MainVM.IsReadOnly));
            _viewModel.OnPropertyChanged(nameof(MainVM.Visible));
        }
    }
}
