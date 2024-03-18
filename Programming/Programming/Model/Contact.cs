using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Contact
    {
        public string ContactName { get; set; }
        private string _surname;
        private string _phoneNumber;

        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("Value cannot be empty");
                }
                _phoneNumber = value;
            }
        }
        public string Surname
        {
            get { return _surname; }
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("Value cannot be empty");
                }
                _surname = value;
            }
        }
        public Contact(string contactname, string surname, string phoneNumber)
        {
            ContactName = contactname;
            Surname = surname;
            PhoneNumber = phoneNumber;
        }
        public Contact()
        {
            ContactName = "Alex";
            Surname = "Petrov";
            PhoneNumber = "89637009911";
        }
    }
}
