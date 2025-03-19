using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Forms
{
    internal partial class AddDiscountForm : Form
    {
        public Category SelectedValue { get; private set; }
        public DialogResult Result { get; private set; }

        public AddDiscountForm()
        {
            InitializeComponent();
            var categories = Enum.GetValues(typeof(Category));
            foreach (var category in categories)
            {
                CategoryComboBox.Items.Add(category);
            }
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedValue = (Category)Enum.Parse(typeof(Category), CategoryComboBox.Text);
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (CategoryComboBox.SelectedIndex == -1) return;
            Result = DialogResult.OK;
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Result = DialogResult.Cancel;
            this.Close();
        }
    }
}
