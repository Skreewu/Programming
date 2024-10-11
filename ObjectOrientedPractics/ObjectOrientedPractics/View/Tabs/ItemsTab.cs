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
using ObjectOrientedPractics.Services;
using System.Text.Json;

namespace ObjectOrientedPractics.View.Tabs
{
    internal partial class ItemsTab : UserControl
    {
        static List<Item> _items = new List<Item>();
        Item _currentItem = new Item();
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
                UpdateInfo();
            }
        }
        public ItemsTab()
        {
            InitializeComponent();
            var categories = Enum.GetValues(typeof(Category));
            foreach (var category in categories)
            {
                CategoryComboBox.Items.Add(category);
            }
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
            CategoryComboBox.SelectedIndex = (int)item.Category;
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
        /// <summary>
        /// Обновляет информацию в списке.
        /// </summary>
        private void UpdateInfo()
        {
            int index = ItemsListBox.Items.IndexOf(_currentItem);
            if (index == -1) return;
            ItemsListBox.Items.Clear();
            ItemsListBox.Items.AddRange(_items.ToArray());
            ItemsListBox.SelectedIndex = index;
        }
        /// <summary>
        /// Очищает поля.
        /// </summary>
        private void ClearInfo()
        {
            NameTextBox.Clear();
            DescriptionTextBox.Clear();
            CostTextBox.Clear();
            IdTextBox.Clear();
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ItemsListBox.Items.IndexOf(_currentItem);
            if (index == -1) return;
            try
            {
                CategoryComboBox.BackColor = AppColors.basicWhite;
                Category category = (Category)Enum.Parse(typeof(Category), CategoryComboBox.Text);
                _currentItem.Category = category;
                UpdateInfo();
            }
            catch
            {
                CategoryComboBox.BackColor = AppColors.errors;
            }
        }
    }
}
