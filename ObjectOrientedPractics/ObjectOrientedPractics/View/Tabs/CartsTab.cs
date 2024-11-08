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
using ObjectOrientedPractics.Model.Orders;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ObjectOrientedPractics.View.Tabs
{
    internal partial class CartsTab : UserControl
    {
        double discountSum = 0;
        List<Item> _items = new List<Item>();
        Item _currentItem = new Item(false);
        Customer _currentCustomer = new Customer(false);
        List<Customer> _customers = new List<Customer>();


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
            DiscountsListBox.Items.Clear();
            DiscountsListBox.Items.AddRange(_currentCustomer.Discounts.ToArray());
            for (int i = 0; i < DiscountsListBox.Items.Count; i++)
            {
                DiscountsListBox.SetItemChecked(i, true);
            }
            AmountLabel.Text = "0";
            DiscountAmountLabel.Text = "0";
            TotalLabel.Text = "0";
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex == -1 || CustomerComboBox.SelectedIndex == -1) return;
            _currentCustomer.Cart.Items.Add(_currentItem);
            CartListBox.Items.Add(_currentItem);
            AmountLabel.Text = _currentCustomer.Cart.Amount.ToString();
            UpdateDiscounts();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (CartListBox.SelectedIndex == -1 || CustomerComboBox.SelectedIndex == -1) return;
            _currentCustomer.Cart.Items.RemoveAt(CartListBox.SelectedIndex);
            CartListBox.Items.RemoveAt(CartListBox.SelectedIndex);
            AmountLabel.Text = _currentCustomer.Cart.Amount.ToString();
            UpdateDiscounts();
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
                PriorityOrder order = new PriorityOrder(_currentCustomer.Address, new List<Item>(_currentCustomer.Cart.Items), true);
                order.DiscountAmount = discountSum;
                _currentCustomer.Orders.Add(order);
            }
            else
            {
                Order order = new Order(_currentCustomer.Address, new List<Item>(_currentCustomer.Cart.Items), true);
                order.DiscountAmount = discountSum;
                _currentCustomer.Orders.Add(order);
            }
            ApplyDiscounts();
            _currentCustomer.Cart.Items.Clear();
            CartListBox.Items.Clear();
            AmountLabel.Text = "0";
            DiscountAmountLabel.Text = "0";
            TotalLabel.Text = "0";
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            _currentCustomer.Cart.Items.Clear();
            CartListBox.Items.Clear();
            AmountLabel.Text = "0";
            UpdateDiscounts();
        }

        private void CartsTab_Load(object sender, EventArgs e)
        {

        }

        private void DiscountsListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            
        }

        private void DiscountsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDiscounts();
        }
        public void UpdateDiscounts()
        {
            discountSum = 0;

            for (int i = 0; i < DiscountsListBox.Items.Count; i++)
            {
                if (DiscountsListBox.GetItemChecked(i))
                {
                    discountSum += _currentCustomer.Discounts[i].Calculate(_currentCustomer.Cart.Items);
                }
            }
            DiscountAmountLabel.Text = discountSum.ToString();
            TotalLabel.Text = (_currentCustomer.Cart.Amount - discountSum).ToString();
        }
        public void ApplyDiscounts()
        {
            for (int i = 0; i < DiscountsListBox.Items.Count; i++)
            {
                if (DiscountsListBox.GetItemChecked(i))
                {
                    _currentCustomer.Discounts[i].Apply(_currentCustomer.Cart.Items);
                }
            }
            foreach (var discount in _currentCustomer.Discounts)
            {
                discount.Update(_currentCustomer.Cart.Items);
            }
            DiscountsListBox.Items.Clear();
            DiscountsListBox.Items.AddRange(_currentCustomer.Discounts.ToArray());
            for (int i = 0; i < DiscountsListBox.Items.Count; i++)
            {
                DiscountsListBox.SetItemChecked(i, true);
            }
        }
    }
}
