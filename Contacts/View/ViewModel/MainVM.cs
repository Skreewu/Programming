using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using View.Model;
using View.Model.Services;

namespace View.ViewModel
{
    internal class MainVM : INotifyPropertyChanged
    {
        private readonly ContactSerializer _contactSerializer;
        public ICommand SaveCommand { get; }
        public ICommand LoadCommand { get; }

        private Contact _contact;

        public MainVM()
        {
            _contact = new Contact();
            _contactSerializer = new ContactSerializer();
            SaveCommand = new SaveCommand(_contactSerializer, _contact);
            LoadCommand = new LoadCommand(_contactSerializer, this);
        }
        public string Name
        {
            get { return _contact.Name; }
            set
            {
                if (_contact.Name != value)
                {
                    _contact.Name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }

        public string PhoneNumber
        {
            get { return _contact.PhoneNumber; }
            set
            {
                if (_contact.PhoneNumber != value)
                {
                    _contact.PhoneNumber = value;
                    OnPropertyChanged(nameof(PhoneNumber));
                }
            }
        }

        public string Email
        {
            get { return _contact.Email; }
            set
            {
                if (_contact.Email != value)
                {
                    _contact.Email = value;
                    OnPropertyChanged(nameof(Email));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
