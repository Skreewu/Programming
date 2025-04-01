using System.Windows.Input;
using View.Model;

namespace View.ViewModel
{
    internal class AddCommand : ICommand
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
        public AddCommand(MainVM viewModel)
        {
            _viewModel = viewModel;
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
        /// Создает объект
        /// </summary>
        /// <param name="parameter"></param>
        public void Execute(object? parameter)
        {
            _viewModel.IsEditOrAdd = true;
            _viewModel.TempContact = new Contact();
            _viewModel.SelectedContact = null;
            _viewModel.OnPropertyChanged(nameof(MainVM.IsReadOnly));
            _viewModel.OnPropertyChanged(nameof(MainVM.Visible));
        }
    }
}
