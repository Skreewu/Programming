using System.Security.Cryptography;

namespace Programming
{
    public partial class MainForm : Form
    {
        Type[] typeModel = new Type[6] { typeof(Colour), typeof(FormOfEducation), typeof(Genre), typeof(Season), typeof(SmartphoneManufacturer), typeof(Weekday) };
        public MainForm()
        {
            InitializeComponent();
        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = EnumsListBox.SelectedIndex;
            object[] values = Enum.GetValues(typeModel[selectedIndex]).Cast<object>().ToArray();
            ValuesListBox.Items.Clear();
            ValuesListBox.Items.AddRange(values);
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
    }
}