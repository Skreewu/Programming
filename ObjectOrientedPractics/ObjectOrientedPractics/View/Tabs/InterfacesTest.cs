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

namespace ObjectOrientedPractics.View.Tabs
{
    internal partial class InterfacesTest : UserControl
    {
        List<Item> _items = new List<Item>();
        Item _currentItem = new Item(false);
        public List<Item> Items
        {
            get
            {
                return _items;
            }
            set
            {
                _items = value;
                ItemListBox.Items.AddRange(_items.ToArray());
                UpdateInfo();

            }
        }
        public InterfacesTest()
        {
            InitializeComponent();
            var categories = Enum.GetValues(typeof(Category));
            foreach (var category in categories)
            {
                CategoryComboBox.Items.Add(category);
            }
        }

        private void ItemListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemListBox.SelectedIndex == -1) return;
            _currentItem = _items[ItemListBox.SelectedIndex];
            Item item = (Item)ItemListBox.SelectedItem;
            IdTextBox.Text = item.Id.ToString();
            CostTextBox.Text = item.Cost.ToString();
            NameTextBox.Text = item.Name.ToString();
            DescriptionTextBox.Text = item.Info.ToString();
            CategoryComboBox.SelectedIndex = (int)item.Category;
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            var copy = (Item)_items[0].Clone();
            _items.Add(copy);
            ItemListBox.Items.Add(copy);
            UpdateInfo();
        }

        private void EqualButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Сравнение Equals с первым объектом: {_currentItem.Equals(_items[0])}");
        }

        private void InterfacesTest_Load(object sender, EventArgs e)
        {

        }

        private void CompareToButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Сравнение CompareTo с первым объектом по цене: {_currentItem.CompareTo(_items[0])}");
        }
        private void UpdateInfo()
        {
            int index = ItemListBox.Items.IndexOf(_currentItem);
            if (index == -1) return;
            ItemListBox.Items.Clear();
            ItemListBox.Items.AddRange(_items.ToArray());
            ItemListBox.SelectedIndex = index;
        }
        public void RefreshData()
        {
            ItemListBox.Items.Clear();
            ItemListBox.Items.AddRange(_items.ToArray());
        }
    }
}
