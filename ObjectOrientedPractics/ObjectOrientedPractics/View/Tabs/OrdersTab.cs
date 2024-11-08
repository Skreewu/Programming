using ObjectOrientedPractics.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using ObjectOrientedPractics.Model.Orders;

namespace ObjectOrientedPractics.View.Tabs
{
    internal partial class OrdersTab : UserControl
    {
        List<Customer> _customers = new List<Customer>();
        List<Order> _orders = new List<Order>();
        Order _currentOrder = new Order(false);
        PriorityOrder _currentPriorityOrder = new PriorityOrder(false);
        public List<Customer> Customers
        {
            get
            {
                return _customers;
            }
            set
            {
                _customers = value;
                UpdateOrders();
            }
        }
        public OrdersTab()
        {
            InitializeComponent();
            foreach (OrderStatus status in Enum.GetValues(typeof(OrderStatus)))
            {
                StatusComboBox.Items.Add(status);
            }
        }
        /// <summary>
        /// Обновляет данные в таблице.
        /// </summary>
        public void UpdateOrders()
        {
            _orders.Clear();
            OrdersDataGrid.Rows.Clear();
            foreach (Customer customer in _customers)
            {
                foreach (Order order in customer.Orders)
                {
                    _orders.Add(order);
                    int rowIndex = OrdersDataGrid.Rows.Add();
                    DataGridViewRow row = OrdersDataGrid.Rows[rowIndex];
                    if (order is PriorityOrder)
                    {
                        row.Cells["isPriority"].Value = "★";
                    }
                    row.Cells["IdColumn"].Value = order.Id;
                    row.Cells["DateColumn"].Value = $"{order.OrderCreationDate.Day}:{order.OrderCreationDate.Month}:{order.OrderCreationDate.Year}";
                    row.Cells["NameColumn"].Value = customer.FullName;
                    row.Cells["AddressColumn"].Value = order.Address.ToString();
                    row.Cells["AmountColumn"].Value = order.Amount;
                    row.Cells["StatusColumn"].Value = order.Status;
                    row.Cells["TotalColumn"].Value = order.Total;
                }
            }
        }

        private void OrdersDataGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (_orders[OrdersDataGrid.SelectedCells[0].RowIndex] is PriorityOrder)
            {
                _currentOrder = _orders[OrdersDataGrid.SelectedCells[0].RowIndex];
                _currentPriorityOrder = (PriorityOrder)_orders[OrdersDataGrid.SelectedCells[0].RowIndex];
                IdTextBox.Text = _currentOrder.Id.ToString();
                DateTextBox.Text = $"{_currentOrder.OrderCreationDate.Day}:{_currentOrder.OrderCreationDate.Month}:{_currentOrder.OrderCreationDate.Year}";
                StatusComboBox.SelectedIndex = (int)_currentOrder.Status;
                addressControl1.Address = _currentOrder.Address;
                ItemsListBox.Items.Clear();
                ItemsListBox.Items.AddRange(_currentOrder.Items.ToArray());
                AmountLabel.Text = _currentOrder.Amount.ToString();
                TotalLabel.Text = _currentOrder.Total.ToString();
                PriorityOptionsPanel.Visible = true;
                DeliveryTimeComboBox.SelectedIndex = (int)_currentPriorityOrder.DesiredDeliveryTimeSlot;
            }
            else
            {
                _currentOrder = _orders[OrdersDataGrid.SelectedCells[0].RowIndex];
                _currentPriorityOrder = null;
                IdTextBox.Text = _currentOrder.Id.ToString();
                DateTextBox.Text = $"{_currentOrder.OrderCreationDate.Day}:{_currentOrder.OrderCreationDate.Month}:{_currentOrder.OrderCreationDate.Year}";
                StatusComboBox.SelectedIndex = (int)_currentOrder.Status;
                addressControl1.Address = _currentOrder.Address;
                ItemsListBox.Items.Clear();
                ItemsListBox.Items.AddRange(_currentOrder.Items.ToArray());
                AmountLabel.Text = _currentOrder.Amount.ToString();
                TotalLabel.Text = _currentOrder.Total.ToString();
                PriorityOptionsPanel.Visible = false;
            }
        }

        private void addressControl1_Load(object sender, EventArgs e)
        {
            addressControl1.ReadOnly();
        }

        private void AmountTextLabel_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void DeliveryTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DeliveryTimeComboBox.SelectedIndex == -1) return;
            Array deliveryTime = Enum.GetValues(typeof(DeliveryTimeSlot));
            _currentPriorityOrder.DesiredDeliveryTimeSlot = (DeliveryTimeSlot)deliveryTime.GetValue(DeliveryTimeComboBox.SelectedIndex);
        }

        private void DeleteOrderButton_Click(object sender, EventArgs e)
        {

        }
    }
}
