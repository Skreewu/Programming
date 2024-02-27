using System.Security.Cryptography;

namespace Programming
{
    public partial class MainForm : Form
    {
        Type[] typeModel = new Type[6] { typeof(Colour), typeof(FormOfEducation), typeof(Genre), typeof(Season), typeof(SmartphoneManufacturer), typeof(Weekday) };
        // Каждый элемент массива представляет собой объект типа Type, который представляет информацию о типе данных во время выполнения программы
        public MainForm()
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

        private void ChooseEnumeration_Click(object sender, EventArgs e)
        {

        }

        private void ChooseValue_Click(object sender, EventArgs e)
        {

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

        private void ChooseSeasonButton_Click(object sender, EventArgs e)
        {
            if (SeasonComboBox.SelectedItem == null)
            {
                MessageBox.Show("Необходимо выбрать значение!");
            }
            SeasonHandle.BackColor = System.Drawing.Color.White;
            switch (SeasonComboBox.SelectedItem)
            {
                case "Winter":
                    MessageBox.Show("Бррр, холодно!");
                    break;
                case "Spring":
                    SeasonHandle.BackColor = System.Drawing.Color.LightGreen;
                    break;
                case "Summer":
                    MessageBox.Show("Ура! Солнце!");
                    break;
                case "Autumn":
                    SeasonHandle.BackColor = System.Drawing.Color.OrangeRed;
                    break;
            }
        }
    }
}