using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using View.Model.Services;
using View.Model;

namespace View.ViewModel
{
    /// <summary>
    /// Команда сохранения объекта в файл.
    /// </summary>
    class SaveCommand : ICommand
    {
        private readonly ContactSerializer _contactSerializer;
        private readonly Contact _contact;

        /// <summary>
        /// Создает объект класса <see cref="SaveCommand"/>
        /// </summary>
        /// <param name="contactSerializer">Сериализатор.</param>
        /// <param name="contact">Контакт для сохранения.</param>
        public SaveCommand(ContactSerializer contactSerializer, Contact contact)
        {
            _contactSerializer = contactSerializer;
            _contact = contact;
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
        public bool CanExecute(object parameter) { return true; }

        /// <summary>
        /// Сохраняет в файл.
        /// </summary>
        /// <param name="parameter"></param>
        public void Execute(object parameter)
        {
            _contactSerializer.SaveInFile(_contact);
        }
    }
}
