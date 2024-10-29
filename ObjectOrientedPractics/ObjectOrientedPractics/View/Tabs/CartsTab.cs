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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ObjectOrientedPractics.View.Tabs
{
    internal partial class CartsTab : UserControl
    {
        List<Item> _items = new List<Item>();
        Item _currentItem = new Item();
        List<Customer> _customers = new List<Customer>();
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
                CustomerComboBox.Items.AddRange(_customers.ToArray());
            }
        }
        public List<Item> Items
        {
            get
            {
                return _items;
            }
            set
            {
                _items = value;
                ItemsListBox.Items.AddRange(_items.ToArray());
            }
        }
        public CartsTab()
        {
            InitializeComponent();
        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex == -1) return;
            _currentItem = _items[ItemsListBox.SelectedIndex];
        }

        private void CustomerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentCustomer = _customers[CustomerComboBox.SelectedIndex];
            CartListBox.Items.Clear();
            CartListBox.Items.AddRange(_currentCustomer.Cart.Items.ToArray());
            AmountLabel.Text = "0";
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex == -1 || CustomerComboBox.SelectedIndex == -1) return;
            _currentCustomer.Cart.Items.Add(_currentItem);
            CartListBox.Items.Add(_currentItem);
            AmountLabel.Text = _currentCustomer.Cart.Amount.ToString();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (CartListBox.SelectedIndex == -1 || CustomerComboBox.SelectedIndex == -1) return;
            _currentCustomer.Cart.Items.RemoveAt(CartListBox.SelectedIndex);
            CartListBox.Items.RemoveAt(CartListBox.SelectedIndex);
            AmountLabel.Text = _currentCustomer.Cart.Amount.ToString();
        }
        public void RefreshData()
        {
            ItemsListBox.Items.Clear();
            ItemsListBox.Items.AddRange(_items.ToArray());
            CustomerComboBox.Items.Clear();
            CustomerComboBox.Items.AddRange(_customers.ToArray());
        }

        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            if (_currentCustomer.IsPriority)
            {
                PriorityOrder order = new PriorityOrder(_currentCustomer.Address, new List<Item>(_currentCustomer.Cart.Items));
                _currentCustomer.Orders.Add(order);
            }
            else
            {
                Order order = new Order(_currentCustomer.Address, new List<Item>(_currentCustomer.Cart.Items));
                _currentCustomer.Orders.Add(order);
            }
            _currentCustomer.Cart.Items.Clear();
            CartListBox.Items.Clear();
            AmountLabel.Text = "0";
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            _currentCustomer.Cart.Items.Clear();
            CartListBox.Items.Clear();
            AmountLabel.Text = "0";
        }
    }
}
