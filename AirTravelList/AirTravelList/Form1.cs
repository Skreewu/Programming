using System;
using System.Diagnostics.Tracing;
using System.Windows.Forms;
using System.Text.Json;
using System.Runtime.Serialization.Json;
using System.IO;

namespace AirTravelList
{
    public partial class MainForm : Form
    {
        List<Flight> _flights = new List<Flight>();
        Flight _currentflight = new Flight();
        bool edit = false;

        public MainForm()
        {
            InitializeComponent();
        }
        private void AddFlightButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(DeparturePointTextBox.Text) && !string.IsNullOrWhiteSpace(DestinationTextBox.Text) && !string.IsNullOrWhiteSpace(FlightTimeTextBox.Text) && TypeOfFlightComboBox.SelectedIndex != -1)
            {
                try
                {
                    DateTime departureTime = DepartureTimePicker.Value;
                    TypesOfFlight typeOfFlight = (TypesOfFlight)Enum.Parse(typeof(TypesOfFlight), TypeOfFlightComboBox.Text);
                    Flight flight = new Flight(DeparturePointTextBox.Text, DestinationTextBox.Text, int.Parse(FlightTimeTextBox.Text), departureTime, typeOfFlight);
                    _flights.Add(flight);
                    _flights.Sort();
                    FlightListBox.Items.Add(flight);
                    UpdateInfo();
                    FlightListBox.SelectedIndex = -1;
                    ClearInfo();
                }
                catch
                {
                    MessageBox.Show("Пункты назначения и отправления не должны содержать больше 100 символов, а время полёта не должно превышать 1000.");
                }
            }
            else
            {
                MessageBox.Show("Введите значения!");
            }
        }

        private void DeleteFlightButton_Click(object sender, EventArgs e)
        {
            int index = FlightListBox.Items.IndexOf(_currentflight);
            if (index == -1) return;
            _flights.RemoveAt(index);
            FlightListBox.Items.RemoveAt(index);
            ClearInfo();
        }

        private void FlightListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FlightListBox.SelectedIndex == -1) return;
            _currentflight = _flights[FlightListBox.SelectedIndex];
            Flight flight = (Flight)FlightListBox.SelectedItem;
            DeparturePointTextBox.Text = flight.DeparturePoint.ToString();
            DestinationTextBox.Text = flight.Destination.ToString();
            FlightTimeTextBox.Text = flight.FlightTime.ToString();
            TypeOfFlightComboBox.SelectedItem = flight.TypeOfFlight.ToString();
            DepartureTimePicker.Value = flight.DepartureTime;
        }

        private void DeparturePointTextBox_TextChanged(object sender, EventArgs e)
        {
            if (edit == true)
            {
                int index = FlightListBox.Items.IndexOf(_currentflight);
                if (index == -1) return;
                try
                {
                    DeparturePointTextBox.BackColor = AppColors.basicWhite;
                    string departurePoint = DeparturePointTextBox.Text;
                    _currentflight.DeparturePoint = departurePoint;
                    _flights.Sort();
                    UpdateInfo();
                }
                catch
                {
                    DeparturePointTextBox.BackColor = AppColors.errors;
                }
            }
        }

        private void DestinationTextBox_TextChanged(object sender, EventArgs e)
        {
            if (edit == true)
            {
                int index = FlightListBox.Items.IndexOf(_currentflight);
                if (index == -1) return;
                try
                {
                    DestinationTextBox.BackColor = AppColors.basicWhite;
                    string destination = DestinationTextBox.Text;
                    _currentflight.Destination = destination;
                    _flights.Sort();
                    UpdateInfo();
                }
                catch
                {
                    DestinationTextBox.BackColor = AppColors.errors;
                }
            }
        }

        private void FlightTimeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (edit == true)
            {
                int index = FlightListBox.Items.IndexOf(_currentflight);
                if (index == -1) return;
                try
                {
                    FlightTimeTextBox.BackColor = AppColors.basicWhite;
                    int flightTime = int.Parse(FlightTimeTextBox.Text);
                    _currentflight.FlightTime = flightTime;
                    _flights.Sort();
                    UpdateInfo();
                }
                catch
                {
                    FlightTimeTextBox.BackColor = AppColors.errors;
                }
            }
        }

        private void TypeOfFlightComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (edit == true)
            {
                int index = FlightListBox.Items.IndexOf(_currentflight);
                if (index == -1) return;
                try
                {
                    TypeOfFlightComboBox.BackColor = AppColors.basicWhite;
                    TypesOfFlight typeOfFlight = (TypesOfFlight)Enum.Parse(typeof(TypesOfFlight), TypeOfFlightComboBox.Text);
                    _currentflight.TypeOfFlight = typeOfFlight;
                    _flights.Sort();
                    UpdateInfo();
                }
                catch
                {
                    TypeOfFlightComboBox.BackColor = AppColors.errors;
                }
            }
        }

        private void DepartureTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (edit == true)
            {
                int index = FlightListBox.Items.IndexOf(_currentflight);
                if (index == -1) return;
                try
                {
                    DepartureTimePicker.BackColor = AppColors.basicWhite;
                    DateTime departureTime = DepartureTimePicker.Value;
                    _currentflight.DepartureTime = departureTime;
                    _flights.Sort();
                    UpdateInfo();
                }
                catch
                {
                    DepartureTimePicker.BackColor = AppColors.errors;
                }
            }
        }
        /// <summary>
        /// Обновляет информацию в ListBox.
        /// </summary>
        private void UpdateInfo()
        {
            int index = FlightListBox.Items.IndexOf(_currentflight);
            if (index == -1) return;
            FlightListBox.Items.Clear();
            FlightListBox.Items.AddRange(_flights.ToArray());
            FlightListBox.SelectedIndex = index;
        }
        /// <summary>
        /// Очищает поля.
        /// </summary>
        private void ClearInfo()
        {
            DeparturePointTextBox.Clear();
            DestinationTextBox.Clear();
            TypeOfFlightComboBox.SelectedIndex = -1;
            FlightTimeTextBox.Clear();
        }
        /// <summary>
        /// Записывает данные типа List<Flight> в JSON-файл.
        /// </summary>
        private void WriteOnFile()
        {
            try
            {
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<Flight>));
                using (FileStream fs = new FileStream("flights.json", FileMode.OpenOrCreate))
                {
                    serializer.WriteObject(fs, _flights);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
        /// <summary>
        /// Считывает данные типа List<Flight> из JSON-файла.
        /// </summary>
        private void ReadFile()
        {
            try
            {
                using (FileStream fs = new FileStream("flights.json", FileMode.Open))
                {
                    DataContractJsonSerializer deserializer = new DataContractJsonSerializer(typeof(List<Flight>));
                    // Десериализация JSON данных из файла в список
                    _flights = (List<Flight>)deserializer.ReadObject(fs);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }

        private void MainForm_Leave(object sender, EventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "flights.json");
            try
            {
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка при удалении файла");
            }
            WriteOnFile();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ReadFile();
            foreach (Flight flight in _flights)
            {
                FlightListBox.Items.Add(flight);
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (edit == false)
            {
                edit = true;
                EditButton.Text = "Режим редактирования";
                SelectedFlightGroupBox.Text = "Выбранный рейс:";
            }
            else
            {
                FlightListBox.SelectedIndex = -1;
                edit = false;
                EditButton.Text = "Режим добавления";
                SelectedFlightGroupBox.Text = "Введите данные о рейсе:";
            }

        }
    }
}
