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
    public partial class Enumerations : UserControl
    {
        Type[] typeModel = new Type[6] { typeof(Colour), typeof(FormOfEducation), typeof(Genre), typeof(Season), typeof(SmartphoneManufacturer), typeof(Weekday) };
        public Enumerations()
        {
            InitializeComponent();
        }
        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = EnumsListBox.SelectedIndex;
            object[] values = Enum.GetValues(typeModel[selectedIndex]).Cast<object>().ToArray();
            // Получает все значения перечисления под некоторым индексом, затем преобразует полученные значения в тип object, а после преобразует последовательность значений в массив объектов.
            ValuesListBox.Items.Clear();
            ValuesListBox.Items.AddRange(values); // Добавляет массив объектов в listbox
        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            intValue.Text = ValuesListBox.SelectedIndex.ToString();
        }

        private void labelIntValue_Click(object sender, EventArgs e)
        {

        }
    }
}
