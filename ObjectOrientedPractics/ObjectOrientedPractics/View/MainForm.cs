using System;
using ObjectOrientedPractics.View.Tabs;
using System.Runtime.Serialization.Json;

namespace ObjectOrientedPractics
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ItemsTab.OnFormClosing(sender, e);
            CustomersTab.OnFormClosing(sender, e);
        }
    }
}
