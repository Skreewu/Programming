using System;
using ObjectOrientedPractics.View.Tabs;
using System.Runtime.Serialization.Json;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics
{
    public partial class MainForm : Form
    {
        Store _store = new Store();
        public MainForm()
        {
            InitializeComponent();
            _store.Items = itemsTab1.Items;
            _store.Customers = customersTab1.Customers;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ItemsTab.OnFormClosing(sender, e);
            CustomersTab.OnFormClosing(sender, e);
        }
    }
}
