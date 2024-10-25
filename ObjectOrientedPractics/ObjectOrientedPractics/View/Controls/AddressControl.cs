using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.View.Controls
{
    public partial class AddressControl : UserControl
    {
        private Address _address = new Address();
        public Address Address
        {
            get 
            { 
                return _address; 
            }
            set
            {
                _address = value;
                IndexTextBox.Text = _address.Index.ToString();
                CountryTextBox.Text = _address.Country;
                CityTextBox.Text = _address.City;
                StreetTextBox.Text = _address.Street;
                BuildingTextBox.Text = _address.Building;
                ApartmentTextBox.Text = _address.Apartment;
            }
        }
        public AddressControl()
        {
            InitializeComponent();
        }

        private void IndexTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                IndexTextBox.BackColor = AppColors.basicWhite;
                int index = Int32.Parse(IndexTextBox.Text);
                _address.Index = index;
            }
            catch
            {
                IndexTextBox.BackColor = AppColors.errors;
            }
        }

        private void CountryTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CountryTextBox.BackColor = AppColors.basicWhite;
                string country = CountryTextBox.Text;
                _address.Country = country;
            }
            catch
            {
                CountryTextBox.BackColor = AppColors.errors;
            }
        }

        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CityTextBox.BackColor = AppColors.basicWhite;
                string city = CityTextBox.Text;
                _address.City = city;
            }
            catch
            {
                CityTextBox.BackColor = AppColors.errors;
            }
        }

        private void StreetTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                StreetTextBox.BackColor = AppColors.basicWhite;
                string street = StreetTextBox.Text;
                _address.Street = street;
            }
            catch
            {
                StreetTextBox.BackColor = AppColors.errors;
            }
        }

        private void BuildingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                BuildingTextBox.BackColor = AppColors.basicWhite;
                string building = BuildingTextBox.Text;
                _address.Building = building;
            }
            catch
            {
                BuildingTextBox.BackColor = AppColors.errors;
            }
        }

        private void ApartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ApartmentTextBox.BackColor = AppColors.basicWhite;
                string apartment = ApartmentTextBox.Text;
                _address.Apartment = apartment;
            }
            catch
            {
                ApartmentTextBox.BackColor = AppColors.errors;
            }
        }
        /// <summary>
        /// Очищает поля.
        /// </summary>
        public void ClearInfo()
        {
            IndexTextBox.Clear();
            CountryTextBox.Clear();
            CityTextBox.Clear();
            StreetTextBox.Clear();
            BuildingTextBox.Clear();
            ApartmentTextBox.Clear();
        }
    }
}
