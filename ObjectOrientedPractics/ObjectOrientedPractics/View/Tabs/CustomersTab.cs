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

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CustomersTab : UserControl
    {
        List<Customer> _customers = new List<Customer>();
        Customer _currentCustomer = new Customer();
        public CustomersTab()
        {
            InitializeComponent();
            Customer customer1 = new Customer("Василий Петров", "г. Санкт-Петербург, ул. Ленина 43");
            Customer customer2 = new Customer("Екатерина Михайлова", "г.Томск, ул. Ф.Лыткина 18");
            Customer customer3 = new Customer("Алексей Иванов", "г.Красноярск, ул. Молокова 10");
            _customers.Add(customer1);
            _customers.Add(customer2);
            _customers.Add(customer3);
            CustomersListBox.Items.AddRange(_customers.ToArray());
        }

        private void AddressLabel_Click(object sender, EventArgs e)
        {

        }

        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex == -1) return;
            _currentCustomer = _customers[CustomersListBox.SelectedIndex];
            Customer customer = (Customer)CustomersListBox.SelectedItem;
            IdTextBox.Text = customer.ID.ToString();
            FullNameTextBox.Text = customer.FullName.ToString();
            AddressTextBox.Text = customer.Address.ToString();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            _customers.Add(customer);
            CustomersListBox.Items.Add(customer);
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            int index = CustomersListBox.Items.IndexOf(_currentCustomer);
            if (index == -1) return;
            _customers.RemoveAt(index);
            CustomersListBox.Items.Remove(index);
            ClearInfo();
        }

        private void IdTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            int index = CustomersListBox.Items.IndexOf(_currentCustomer);
            if (index == -1) return;
            try
            {
                FullNameTextBox.BackColor = AppColors.basicWhite;
                string fullName = FullNameTextBox.Text.ToString();
                _currentCustomer.FullName = fullName;
                UpdateInfo();
            }
            catch
            {
                FullNameTextBox.BackColor = AppColors.errors;
            }
        }

        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {
            int index = CustomersListBox.Items.IndexOf(_currentCustomer);
            if (index == -1) return;
            try
            {
                AddressTextBox.BackColor = AppColors.basicWhite;
                string address = AddressTextBox.Text.ToString();
                _currentCustomer.Address = address;
                UpdateInfo();
            }
            catch
            {
                AddressTextBox.BackColor= AppColors.errors;
            }
        }
        /// <summary>
        /// Обновляет информацию в списке
        /// </summary>
        private void UpdateInfo()
        {
            int index = CustomersListBox.Items.IndexOf(_currentCustomer);
            if (index == -1) return;
            CustomersListBox.Items.Clear();
            CustomersListBox.Items.AddRange(_customers.ToArray());
            CustomersListBox.SelectedIndex = index;
        }
        /// <summary>
        /// Очищает поля.
        /// </summary>
        private void ClearInfo()
        {
            IdTextBox.Clear();
            FullNameTextBox.Clear();
            AddressTextBox.Clear();
        }
    }
}
