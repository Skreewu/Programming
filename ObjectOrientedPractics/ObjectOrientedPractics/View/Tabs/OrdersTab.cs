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

namespace ObjectOrientedPractics.View.Tabs
{
    internal partial class OrdersTab : UserControl
    {
        List<Customer> _customers = new List<Customer>();
        List<Order> _orders = new List<Order>();
        Order _currentOrder = new Order();
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
            var orderStatuses = Enum.GetValues(typeof(OrderStatus));
            foreach (var status in orderStatuses)
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
                    row.Cells["IdColumn"].Value = order.Id;
                    row.Cells["DateColumn"].Value = $"{order.OrderCreationDate.Day}:{order.OrderCreationDate.Month}:{order.OrderCreationDate.Year}";
                    row.Cells["NameColumn"].Value = customer.FullName;
                    row.Cells["AddressColumn"].Value = order.Address.ToString();
                    row.Cells["AmountColumn"].Value = order.Amount;
                    row.Cells["StatusColumn"].Value = order.Status;
                }
            }
        }

        private void OrdersDataGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _currentOrder = _orders[OrdersDataGrid.SelectedCells[0].RowIndex];
            IdTextBox.Text = _currentOrder.Id.ToString();
            DateTextBox.Text = $"{_currentOrder.OrderCreationDate.Day}:{_currentOrder.OrderCreationDate.Month}:{_currentOrder.OrderCreationDate.Year}";
            StatusComboBox.SelectedIndex = (int)_currentOrder.Status;
            addressControl1.IndexTextBoxValue = _currentOrder.Address.Index.ToString();
            addressControl1.CountryTextBoxValue = _currentOrder.Address.Country.ToString();
            addressControl1.CityTextBoxValue = _currentOrder.Address.City.ToString();
            addressControl1.StreetTextBoxValue = _currentOrder.Address.Street.ToString();
            addressControl1.BuildingTextBoxValue = _currentOrder.Address.Building.ToString();
            addressControl1.ApartmentTextBoxValue = _currentOrder.Address.Apartment.ToString();
            ItemsListBox.Items.Clear();
            ItemsListBox.Items.AddRange(_currentOrder.Items.ToArray());
            AmountLabel.Text = _currentOrder.Amount.ToString();
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
    }
}
