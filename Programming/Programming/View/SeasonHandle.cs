using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming.View
{
    public partial class SeasonHandle : UserControl
    {
        public SeasonHandle()
        {
            InitializeComponent();
        }
        private void ChooseEnumeration_Click(object sender, EventArgs e)
        {

        }

        private void ChooseValue_Click(object sender, EventArgs e)
        {

        }
        private void ChooseSeasonButton_Click(object sender, EventArgs e)
        {
            if (SeasonComboBox.SelectedItem == null)
            {
                MessageBox.Show("Необходимо выбрать значение!");
            }
            switch (SeasonComboBox.SelectedItem)
            {
                case "Winter":
                    MessageBox.Show("Бррр, холодно!");
                    break;
                case "Spring":
                    MessageBox.Show("Весна");
                    break;
                case "Summer":
                    MessageBox.Show("Ура! Солнце!");
                    break;
                case "Autumn":
                    MessageBox.Show("Осень");
                    break;
            }
        }
    }
}
