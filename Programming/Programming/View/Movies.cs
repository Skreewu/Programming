using Programming.Model;
using Programming.Model.Classes;
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
    public partial class Movies : UserControl
    {
        Film _currentfilm = new Film();
        Film[] _films = new Film[]
        {
            new Film("Fight Club", "Thriller", 139, 1999, 8.7),
            new Film("Inception", "Fantastic", 148, 2010, 8.7),
            new Film("Bruce Almighty", "Comedy", 97, 2003, 7.7),
            new Film("In Time", "Action Movie", 109, 2011, 7.3),
            new Film("Blade Runner 2049", "Action Movie", 164, 2017, 7.8)
        };
        public Movies()
        {
            InitializeComponent();
            FilmsListBox.Items.AddRange(_films);
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
            if (index == -1) return;
            FilmsListBox.Items.RemoveAt(index);
            FilmsListBox.Items.Insert(index, _currentfilm);
            try
            {
                FilmNameTextBox.BackColor = AppColors.basicWhite;
                string filmname = FilmNameTextBox.Text;
                _currentfilm.FilmName = filmname;
            }
            catch (Exception)
            {
                FilmNameTextBox.BackColor = AppColors.errors;
            }
        }

        private void FilmGenreTextBox_TextChanged(object sender, EventArgs e)
        {
            int index = FilmsListBox.Items.IndexOf(_currentfilm);
            if (index == -1) return;
            FilmsListBox.Items.RemoveAt(index);
            FilmsListBox.Items.Insert(index, _currentfilm);
            try
            {
                FilmGenreTextBox.BackColor = AppColors.basicWhite;
                string filmgenre = FilmGenreTextBox.Text;
                _currentfilm.Genre = filmgenre;
            }
            catch (Exception)
            {
                FilmGenreTextBox.BackColor = AppColors.errors;
            }
        }

        private void FilmDurationTextBox_TextChanged(object sender, EventArgs e)
        {
            int index = FilmsListBox.Items.IndexOf(_currentfilm);
            if (index == -1) return;
            FilmsListBox.Items.RemoveAt(index);
            FilmsListBox.Items.Insert(index, _currentfilm);
            try
            {
                FilmDurationTextBox.BackColor = AppColors.basicWhite;
                int filmDuration = int.Parse(FilmDurationTextBox.Text);
                _currentfilm.FilmDuration = filmDuration;
            }
            catch (Exception)
            {
                FilmDurationTextBox.BackColor = AppColors.errors;
            }
        }

        private void ReleaseYearTextBox_TextChanged(object sender, EventArgs e)
        {
            int index = FilmsListBox.Items.IndexOf(_currentfilm);
            if (index == -1) return;
            FilmsListBox.Items.RemoveAt(index);
            FilmsListBox.Items.Insert(index, _currentfilm);
            try
            {
                ReleaseYearTextBox.BackColor = AppColors.basicWhite;
                int releaseYear = int.Parse(ReleaseYearTextBox.Text);
                _currentfilm.ReleaseYear = releaseYear;
            }
            catch (Exception)
            {
                ReleaseYearTextBox.BackColor = AppColors.errors;
            }
        }

        private void FilmRateTextBox_TextChanged(object sender, EventArgs e)
        {
            int index = FilmsListBox.Items.IndexOf(_currentfilm);
            if (index == -1) return;
            FilmsListBox.Items.RemoveAt(index);
            FilmsListBox.Items.Insert(index, _currentfilm);
            try
            {
                FilmRateTextBox.BackColor = AppColors.basicWhite;
                double filmrate = double.Parse(FilmRateTextBox.Text);
                _currentfilm.Rate = filmrate;
            }
            catch (Exception)
            {
                FilmRateTextBox.BackColor = AppColors.errors;
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
