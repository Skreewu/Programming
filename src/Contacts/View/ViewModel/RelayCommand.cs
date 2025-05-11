using System.Windows.Input;

namespace View.ViewModel
{
    /// <summary>
    /// Универсальная команда, которая принимает методы для выполнения и проверки возможности выполнения.
    /// </summary>
    internal class RelayCommand : ICommand
    {

        /// <summary>
        /// Делегат, содержащий логику выполнения команды.
        /// Принимает параметр команды типа <see cref="object"/>.
        /// </summary>
        private readonly Action<object> _execute;

        /// <summary>
        /// Делегат, определяющий возможность выполнения команды.
        /// Принимает параметр команды типа <see cref="object"/> и возвращает <see cref="bool"/>.
        /// Если равен null, команда всегда доступна для выполнения.
        /// </summary>
        private readonly Func<object, bool> _canExecute;

        /// <summary>
        /// Флаг, указывающий, нужно ли автоматически вызывать перепроверку
        /// возможности выполнения команды через <see cref="CommandManager"/>.
        /// Если true, команда будет автоматически обновлять свой статус при изменениях в UI.
        /// </summary>
        private readonly bool _useCommandManager;

        /// <summary>
        /// Создает новую команду.
        /// </summary>
        /// <param name="execute">Действие для выполнения.</param>
        /// <param name="canExecute">Функция проверки возможности выполнения.</param>
        /// <param name="useCommandManager">Использовать CommandManager для перепроверки CanExecute.</param>
        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null, bool useCommandManager = false)
        {
            _execute = execute ?? throw new ArgumentNullException(nameof(execute));
            _canExecute = canExecute;
            _useCommandManager = useCommandManager;
        }

        /// <summary>
        /// Событие, вызываемое при изменении возможности выполнения команды.
        /// </summary>
        public event EventHandler CanExecuteChanged
        {
            add
            {
                if (_useCommandManager)
                {
                    CommandManager.RequerySuggested += value;
                }
            }
            remove
            {
                if (_useCommandManager)
                {
                    CommandManager.RequerySuggested -= value;
                }
            }
        }

        /// <summary>
        /// Проверяет, можно ли выполнить команду.
        /// </summary>
        public bool CanExecute(object parameter)
        {
            return _canExecute == null || _canExecute(parameter);
        }

        /// <summary>
        /// Выполняет команду.
        /// </summary>
        public void Execute(object parameter)
        {
            _execute(parameter);
        }
    }
}