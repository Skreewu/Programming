using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    internal class Contact
    {
        public string _name;
        private string _surname;
        private string _phoneNumber;

        public string Name
        {
            get { return _name; }
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("Value cannot be empty");
                }
                if (AssertStringContainsOnlyLetters(value) == false)
                {
                    throw new ArgumentException("Name should consist only of letters of the English alphabet");
                }
                _name = value;
            }
        }
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
                if (AssertStringContainsOnlyLetters(value) == false)
                {
                    throw new ArgumentException("Surname should consist only of letters of the English alphabet");
                }
                _surname = value;
            }
        }
        public Contact(string contactname, string surname, string phoneNumber)
        {
            Name = contactname;
            Surname = surname;
            PhoneNumber = phoneNumber;
        }
        public Contact()
        {
            Name = "Alex";
            Surname = "Petrov";
            PhoneNumber = "89637009911";
        }
        private bool AssertStringContainsOnlyLetters(string value)
        {
            value.ToLower();
            foreach (char c in value)
            {
                if (c >= 'a' && c <= 'z')
                {
                    return true;
                }
            }
            return false;
        }
    }
}
