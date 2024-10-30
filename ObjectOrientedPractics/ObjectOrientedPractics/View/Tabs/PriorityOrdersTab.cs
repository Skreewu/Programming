using ObjectOrientedPractics.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    internal partial class PriorityOrdersTab : UserControl
    {
        PriorityOrder _priorityOrder = new PriorityOrder(false);
        List<Item> _items = new List<Item>();
        public List<Item> Items
        {
            get { return _items; }
            set { _items = value; }
        }
        public PriorityOrdersTab()
        {
            InitializeComponent();
            var statuses = Enum.GetValues(typeof(OrderStatus));
            foreach (var status in statuses)
            {
                StatusComboBox.Items.Add(status);
            }
            var deliveryTime = Enum.GetValues(typeof(DeliveryTimeSlot));
            foreach (var time in deliveryTime)
            {
                DeliveryTimeComboBox.Items.Add(time);
            }
            IdTextBox.Text = _priorityOrder.Id.ToString();
            CreationTimeTextBox.Text = _priorityOrder.OrderCreationDate.ToString();
            StatusComboBox.SelectedItem = _priorityOrder.Status;
            addressControl1.Address = _priorityOrder.Address;
            OrderItemsListBox.Items.AddRange(_priorityOrder.Items.ToArray());

        }

        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _priorityOrder.Status = (OrderStatus)Enum.Parse(typeof(OrderStatus), StatusComboBox.Text);
        }

        private void DeliveryTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _priorityOrder.DesiredDeliveryTimeSlot = (DeliveryTimeSlot)Enum.Parse(typeof(DeliveryTimeSlot), DeliveryTimeComboBox.Text);
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            _priorityOrder.Items.Add(Items[0]);
            UpdateInfo();
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (OrderItemsListBox.SelectedIndex == -1) return;
            _priorityOrder.Items.RemoveAt(OrderItemsListBox.SelectedIndex);
            UpdateInfo();
        }

        private void ClearOrderButton_Click(object sender, EventArgs e)
        {
            _priorityOrder = null;
            _priorityOrder = new PriorityOrder(false);
            UpdateInfo();
            IdTextBox.Text = _priorityOrder.Id.ToString();
            CreationTimeTextBox.Text = _priorityOrder.OrderCreationDate.ToString();
            StatusComboBox.SelectedItem = _priorityOrder.Status;
        }
        private void UpdateInfo()
        {
            OrderItemsListBox.Items.Clear();
            OrderItemsListBox.Items.AddRange(_priorityOrder.Items.ToArray());
            AmountLabel.Text = _priorityOrder.Amount.ToString();
        }
    }
}
