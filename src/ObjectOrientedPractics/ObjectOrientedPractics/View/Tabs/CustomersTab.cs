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
using ObjectOrientedPractics.Model.Discounts;
using ObjectOrientedPractics.Services;
using ObjectOrientedPractics.View.Controls;
using ObjectOrientedPractics.View.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace ObjectOrientedPractics.View.Tabs
{
    internal partial class CustomersTab : UserControl
    {
        static List<Customer> _customers = new List<Customer>();
        Customer _currentCustomer = new Customer(false);
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
            IdTextBox.Text = _currentCustomer.Id.ToString();
            FullNameTextBox.Text = _currentCustomer.FullName.ToString();
            addressControl1.Address = _currentCustomer.Address;
            IsPriorityCheckBox.Checked = _currentCustomer.IsPriority;
            DiscountsListBox.Items.Clear();
            DiscountsListBox.Items.AddRange(_currentCustomer.Discounts.ToArray());
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer(true);
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
            DiscountsListBox.Items.Clear();
            DiscountsListBox.Items.AddRange(_currentCustomer.Discounts.ToArray());
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

        private void IsPriorityCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (IsPriorityCheckBox.Checked == true)
            {
                _currentCustomer.IsPriority = true;
            }
            else
            {
                _currentCustomer.IsPriority = false;
            }
        }

        private void AddDiscountButton_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex == -1) return;
            AddDiscountForm addDiscountForm = new AddDiscountForm();
            addDiscountForm.ShowDialog();
            if (addDiscountForm.Result == DialogResult.OK)
            {
                bool isContains = false;
                foreach (var discount in _currentCustomer.Discounts)
                {
                    if (discount is PercentDiscount percentDiscount1)
                    {
                        if (percentDiscount1.Category == addDiscountForm.SelectedValue)
                        {
                            isContains = true;
                            break;
                        }
                    }
                }
                if (!isContains)
                {
                    _currentCustomer.Discounts.Add(new PercentDiscount(addDiscountForm.SelectedValue));
                    UpdateInfo();
                }
            }
        }

        private void RemoveDiscountButton_Click(object sender, EventArgs e)
        {
            if (DiscountsListBox.SelectedIndex == 0 || DiscountsListBox.SelectedIndex == -1 || CustomersListBox.SelectedIndex == -1)
            {
                return;
            }
            _currentCustomer.Discounts.RemoveAt(DiscountsListBox.SelectedIndex);
            UpdateInfo();
        }
    }
}
