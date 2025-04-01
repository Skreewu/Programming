using System.Windows.Input;

namespace View.ViewModel
{
    internal class RemoveCommand : ICommand
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
        public RemoveCommand(MainVM viewModel)
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
            int index = _viewModel.Contacts.IndexOf(_viewModel.SelectedContact);
            _viewModel.Contacts.Remove(_viewModel.SelectedContact);

            if (_viewModel.Contacts.Count > 0)
            {
                if (index >= _viewModel.Contacts.Count)
                {
                    index = _viewModel.Contacts.Count - 1;
                }
                _viewModel.SelectedContact = _viewModel.Contacts[index];
            }
            else
            {
                _viewModel.SelectedContact = null;
            }

            _viewModel.OnPropertyChanged(nameof(MainVM.IsEnabled));
        }
    }
}
