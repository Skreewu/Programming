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
    public partial class WeekdayParsing : UserControl
    {
        public WeekdayParsing()
        {
            InitializeComponent();
        }
        private void TextBoxParsing_TextChanged(object sender, EventArgs e)
        {

        }

        private void ParseButton_Click(object sender, EventArgs e)
        {
            string enteredValue = TextBoxParsing.Text.First().ToString().ToUpper() + TextBoxParsing.Text.Substring(1).ToLower();
            Weekday day;
            if (int.TryParse(enteredValue, out _))
            {
                labelResultParsing.Text = "Введено неверное значение";
            }
            else if (Enum.TryParse(enteredValue, out day))
            {
                labelResultParsing.Text = $"Это день недели ({day} = {(int)day})";
            }
            else
            {
                labelResultParsing.Text = "Нет такого дня недели";
            }
        }
    }
}
