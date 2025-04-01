using System.Windows.Input;
using View.Model;

namespace View.ViewModel
{
    internal class ApplyCommand : ICommand
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
        public ApplyCommand(MainVM viewModel)
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
            return _viewModel.IsEditOrAdd &&
                   !string.IsNullOrWhiteSpace(_viewModel.TempContact?.Name) &&
                   !string.IsNullOrWhiteSpace(_viewModel.TempContact?.PhoneNumber) &&
                   !string.IsNullOrWhiteSpace(_viewModel.TempContact?.Email);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="parameter"></param>
        public void Execute(object? parameter)
        {
            if (_viewModel.SelectedContact == null)
            {
                // Добавление нового контакта
                var newContact = new Contact(
                    _viewModel.TempContact.Name,
                    _viewModel.TempContact.PhoneNumber,
                    _viewModel.TempContact.Email);
                _viewModel.Contacts.Add(newContact);
                _viewModel.SelectedContact = newContact;
            }
            else
            {
                // Редактирование существующего контакта
                _viewModel.SelectedContact.Name = _viewModel.TempContact.Name;
                _viewModel.SelectedContact.PhoneNumber = _viewModel.TempContact.PhoneNumber;
                _viewModel.SelectedContact.Email = _viewModel.TempContact.Email;
            }

            _viewModel.IsEditOrAdd = false;
            _viewModel.TempContact = null;
            _viewModel.OnPropertyChanged(nameof(MainVM.IsReadOnly));
            _viewModel.OnPropertyChanged(nameof(MainVM.Visible));
        }
    }
}
