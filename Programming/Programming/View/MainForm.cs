using Programming.Model.Classes;
using System;
using System.Drawing;

namespace Programming
{
    public partial class MainForm : Form
    {
        Type[] typeModel = new Type[6] { typeof(Colour), typeof(FormOfEducation), typeof(Genre), typeof(Season), typeof(SmartphoneManufacturer), typeof(Weekday) };
        // Каждый элемент массива представляет собой объект типа Type, который представляет информацию о типе данных во время выполнения программы
        RectangleCustom[] _rectangles = new RectangleCustom[5];
        RectangleCustom _currentRectangle = new RectangleCustom();
        Film _currentfilm = new Film();
        Film[] _films = new Film[]
        {
            new Film("Fight Club", "Thriller", 139, 1999, 8.7),
            new Film("Inception", "Fantastic", 148, 2010, 8.7),
            new Film("Bruce Almighty", "Comedy", 97, 2003, 7.7),
            new Film("In Time", "Action Movie", 109, 2011, 7.3),
            new Film("Blade Runner 2049", "Action Movie", 164, 2017, 7.8)
        };
        public MainForm()
        {
            InitializeComponent();
            Random random = new Random();
            Colour[] colors = (Colour[])Enum.GetValues(typeof(Colour));
            for (int i = 0; i < 5; i++)
            {
                RectangleCustom rectangle = new RectangleCustom(random.Next(1, 50), random.Next(1, 50), colors[random.Next(colors.Length)]);
                _rectangles[i] = rectangle;
                RectanglesListBox.Items.Add(rectangle);
            }
            FilmsListBox.Items.AddRange(_films);
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

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RectanglesListBox.SelectedIndex == -1) return;
            _currentRectangle = _rectangles[RectanglesListBox.SelectedIndex];
            RectangleCustom rectangle = (RectangleCustom)RectanglesListBox.SelectedItem;
            LengthTextBox.Text = rectangle.Length.ToString();
            WidthTextBox.Text = rectangle.Width.ToString();
            ColourTextBox.Text = rectangle.Color.ToString();
        }

        private void LengthTextBox_TextChanged(object sender, EventArgs e)
        {
            int index = RectanglesListBox.Items.IndexOf(_currentRectangle);
            RectanglesListBox.Items.RemoveAt(index);
            RectanglesListBox.Items.Insert(index, _currentRectangle);
            try
            {
                LengthTextBox.BackColor = System.Drawing.Color.White;
                int length = int.Parse(LengthTextBox.Text);
                _currentRectangle.Length = length;
            }
            catch (Exception)
            {
                LengthTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            int index = RectanglesListBox.Items.IndexOf(_currentRectangle);
            RectanglesListBox.Items.RemoveAt(index);
            RectanglesListBox.Items.Insert(index, _currentRectangle);
            try
            {
                WidthTextBox.BackColor = System.Drawing.Color.White;
                int width = int.Parse(WidthTextBox.Text);
                _currentRectangle.Width = width;
            }
            catch (Exception)
            {
                WidthTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void ColourListBox_TextChanged(object sender, EventArgs e)
        {
            int index = RectanglesListBox.Items.IndexOf(_currentRectangle);
            RectanglesListBox.Items.RemoveAt(index);
            RectanglesListBox.Items.Insert(index, _currentRectangle);
            try
            {
                ColourTextBox.BackColor = System.Drawing.Color.White;
                Colour colour = (Colour)Enum.Parse(typeof(Colour), ColourTextBox.Text);
                _currentRectangle.Color = colour;
            }
            catch (Exception)
            {
                ColourTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }
        private int FindRectangleWithMaxWidth(RectangleCustom[] rectangles)
        {
            double maxWidth = Double.NegativeInfinity;
            int maxWidthIndex = 0;
            for (int i = 0; i < rectangles.Length; i++)
            {
                if (rectangles[i].Width > maxWidth)
                {
                    maxWidth = rectangles[i].Width;
                    maxWidthIndex = i;
                }

            }
            return maxWidthIndex;
        }
        private void FindButton_Click(object sender, EventArgs e)
        {
            int index = FindRectangleWithMaxWidth(_rectangles);
            RectanglesListBox.SelectedIndex = index;
        }

        private void FilmsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FilmsListBox.SelectedIndex == -1) return;
            _currentfilm = _films[FilmsListBox.SelectedIndex];
            Film film = (Film)FilmsListBox.SelectedItem;
            FilmNameTextBox.Text = film.FilmName.ToString();
            FilmGenreTextBox.Text = film.Genre.ToString();
            FilmDurationTextBox.Text = film.FilmDuration.ToString();
            ReleaseYearTextBox.Text = film.ReleaseYear.ToString();
            FilmRateTextBox.Text = film.Rate.ToString();
        }

        private void FilmNameTextBox_TextChanged(object sender, EventArgs e)
        {
            int index = FilmsListBox.Items.IndexOf(_currentfilm);
            FilmsListBox.Items.RemoveAt(index);
            FilmsListBox.Items.Insert(index, _currentfilm);
            try
            {
                FilmNameTextBox.BackColor = System.Drawing.Color.White;
                string filmname = FilmNameTextBox.Text;
                _currentfilm.FilmName = filmname;
            }
            catch (Exception)
            {
                FilmNameTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void FilmGenreTextBox_TextChanged(object sender, EventArgs e)
        {
            int index = FilmsListBox.Items.IndexOf(_currentfilm);
            FilmsListBox.Items.RemoveAt(index);
            FilmsListBox.Items.Insert(index, _currentfilm);
            try
            {
                FilmGenreTextBox.BackColor = System.Drawing.Color.White;
                string filmgenre = FilmGenreTextBox.Text;
                _currentfilm.Genre = filmgenre;
            }
            catch (Exception)
            {
                FilmGenreTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void FilmDurationTextBox_TextChanged(object sender, EventArgs e)
        {
            int index = FilmsListBox.Items.IndexOf(_currentfilm);
            FilmsListBox.Items.RemoveAt(index);
            FilmsListBox.Items.Insert(index, _currentfilm);
            try
            {
                FilmDurationTextBox.BackColor = System.Drawing.Color.White;
                int filmDuration = int.Parse(FilmDurationTextBox.Text);
                _currentfilm.FilmDuration = filmDuration;
            }
            catch (Exception)
            {
                FilmDurationTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void ReleaseYearTextBox_TextChanged(object sender, EventArgs e)
        {
            int index = FilmsListBox.Items.IndexOf(_currentfilm);
            FilmsListBox.Items.RemoveAt(index);
            FilmsListBox.Items.Insert(index, _currentfilm);
            try
            {
                ReleaseYearTextBox.BackColor = System.Drawing.Color.White;
                int releaseYear = int.Parse(ReleaseYearTextBox.Text);
                _currentfilm.ReleaseYear = releaseYear;
            }
            catch (Exception)
            {
                ReleaseYearTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void FilmRateTextBox_TextChanged(object sender, EventArgs e)
        {
            int index = FilmsListBox.Items.IndexOf(_currentfilm);
            FilmsListBox.Items.RemoveAt(index);
            FilmsListBox.Items.Insert(index, _currentfilm);
            try
            {
                FilmRateTextBox.BackColor = System.Drawing.Color.White;
                double filmrate = double.Parse(FilmRateTextBox.Text);
                _currentfilm.Rate = filmrate;
            }
            catch (Exception)
            {
                FilmRateTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }
        private int FindFilmWithMaxRate(Film[] films)
        {
            double maxRate = Double.NegativeInfinity;
            int maxRateIndex = 0;
            for (int i = 0; i < films.Length; i++)
            {
                if (films[i].Rate > maxRate)
                {
                    maxRate = films[i].Rate;
                    maxRateIndex = i;
                }
            }
            return maxRateIndex;
        }
        private void FilmFindButton_Click(object sender, EventArgs e)
        {
            int index = FindFilmWithMaxRate(_films);
            FilmsListBox.SelectedIndex = index;
        }
    }
}