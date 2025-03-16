using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using View.Model.Services;
using View.Model;

namespace View.ViewModel
{
    class LoadCommand : ICommand
    {
        private readonly ContactSerializer _contactSerializer;
        private readonly MainVM _viewModel;

        public LoadCommand(ContactSerializer contactSerializer, MainVM viewModel)
        {
            _contactSerializer = contactSerializer;
            _viewModel = viewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter) => true;

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
