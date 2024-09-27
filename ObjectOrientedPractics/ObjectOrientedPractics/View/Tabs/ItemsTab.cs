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
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class ItemsTab : UserControl
    {
        List<Item> _items = new List<Item>();
        Item _currentItem = new Item(); 
        public ItemsTab()
        {
            InitializeComponent();
            Item item1 = new Item("Молоко", "Отборное, пастеризованное", 79.99);
            Item item2 = new Item("Сыр пармезан", "34% 200 грамм", 458);
            Item item3 = new Item("Лазанья", "Макаронные изделия Лазанья, 250 грамм", 90.50);
            _items.Add(item1);
            _items.Add(item2);
            _items.Add(item3);
            ItemsListBox.Items.AddRange(_items.ToArray());
        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex == -1) return;
            _currentItem = _items[ItemsListBox.SelectedIndex];
            Item item = (Item)ItemsListBox.SelectedItem;
            IdTextBox.Text = item.Id.ToString();
            CostTextBox.Text = item.Cost.ToString();
            NameTextBox.Text = item.Name.ToString();
            DescriptionTextBox.Text = item.Info.ToString();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Item item = new Item();
            _items.Add(item);
            ItemsListBox.Items.Add(item);
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            int index = ItemsListBox.Items.IndexOf(_currentItem);
            if (index == -1) return;
            _items.RemoveAt(index);
            ItemsListBox.Items.RemoveAt(index);
            ClearInfo();
        }

        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
            int index = ItemsListBox.Items.IndexOf(_currentItem);
            if (index == -1) return;
            try
            {
                CostTextBox.BackColor = AppColors.basicWhite;
                double cost = double.Parse(CostTextBox.Text);
                _currentItem.Cost = cost;
                UpdateInfo();
            }
            catch
            {
                CostTextBox.BackColor = AppColors.errors;
            }
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            int index = ItemsListBox.Items.IndexOf(_currentItem);
            if (index == -1) return;
            try
            {
                NameTextBox.BackColor = AppColors.basicWhite;
                string name = NameTextBox.Text.ToString();
                _currentItem.Name = name;
                UpdateInfo();
            }
            catch
            {
                NameTextBox.BackColor = AppColors.errors;
            }
        }

        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            int index = ItemsListBox.Items.IndexOf(_currentItem);
            if (index == -1) return;
            try
            {
                DescriptionTextBox.BackColor = AppColors.basicWhite;
                string description = DescriptionTextBox.Text.ToString();
                _currentItem.Info = description;
                UpdateInfo();
            }
            catch
            {
                DescriptionTextBox.BackColor = AppColors.errors;
            }
        }
        private void UpdateInfo()
        {
            int index = ItemsListBox.Items.IndexOf(_currentItem);
            if (index == -1) return;
            ItemsListBox.Items.Clear();
            ItemsListBox.Items.AddRange(_items.ToArray());
            ItemsListBox.SelectedIndex = index;
        }
        private void ClearInfo()
        {
            NameTextBox.Clear();
            DescriptionTextBox.Clear();
            CostTextBox.Clear();
            IdTextBox.Clear();
        }
    }
}
