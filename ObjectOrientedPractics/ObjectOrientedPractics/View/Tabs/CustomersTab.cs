using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
using ObjectOrientedPractics.View.Controls;

namespace ObjectOrientedPractics.View.Tabs
{
    internal partial class CustomersTab : UserControl
    {
        static List<Customer> _customers = new List<Customer>();
        Customer _currentCustomer = new Customer();
        public List<Customer> Customers
        {
            get 
            { 
                return _customers; 
            }
            set
            {
                _customers = value;
                CustomersListBox.Items.AddRange(_customers.ToArray());
                UpdateInfo();
            }
        }
        public CustomersTab()
        {
            InitializeComponent();
        }

        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex == -1) return;
            _currentCustomer = _customers[CustomersListBox.SelectedIndex];
            Customer customer = (Customer)CustomersListBox.SelectedItem;
            IdTextBox.Text = customer.Id.ToString();
            FullNameTextBox.Text = customer.FullName.ToString();
            addressControl1.Address = customer.Address;
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
            addressControl1.ClearInfo();
        } 
    }
}
