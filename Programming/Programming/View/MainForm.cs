using System.Security.Cryptography;

namespace Programming
{
    public partial class MainForm : Form
    {
        Type[] typeModel = new Type[6] { typeof(Colour), typeof(FormOfEducation), typeof(Genre), typeof(Season), typeof(SmartphoneManufacturer), typeof(Weekday) };
        // ������ ������� ������� ������������ ����� ������ ���� Type, ������� ������������ ���������� � ���� ������ �� ����� ���������� ���������
        public MainForm()
        {
            InitializeComponent();
        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = EnumsListBox.SelectedIndex;
            object[] values = Enum.GetValues(typeModel[selectedIndex]).Cast<object>().ToArray();
            // �������� ��� �������� ������������ ��� ��������� ��������, ����� ����������� ���������� �������� � ��� object, � ����� ����������� ������������������ �������� � ������ ��������.
            ValuesListBox.Items.Clear();
            ValuesListBox.Items.AddRange(values); // ��������� ������ �������� � listbox
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
                labelResultParsing.Text = "������� �������� ��������";
            }
            else if (Enum.TryParse(enteredValue, out day))
            {
                labelResultParsing.Text = $"��� ���� ������ ({day} = {(int)day})";
            }
            else
            {
                labelResultParsing.Text = "��� ������ ��� ������";
            }
        }

        private void ChooseSeasonButton_Click(object sender, EventArgs e)
        {
            if (SeasonComboBox.SelectedItem == null)
            {
                MessageBox.Show("���������� ������� ��������!");
            }
            SeasonHandle.BackColor = System.Drawing.Color.White;
            switch (SeasonComboBox.SelectedItem)
            {
                case "Winter":
                    MessageBox.Show("����, �������!");
                    break;
                case "Spring":
                    SeasonHandle.BackColor = System.Drawing.Color.LightGreen;
                    break;
                case "Summer":
                    MessageBox.Show("���! ������!");
                    break;
                case "Autumn":
                    SeasonHandle.BackColor = System.Drawing.Color.OrangeRed;
                    break;
            }
        }
    }
}