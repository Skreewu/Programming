using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Film
    {
        private string FilmName { get; set; }
        private string Genre { get; set; }
        private int _filmDuration;
        private int _releaseYear;
        private double _rate;

        public int FilmDuration
        {
            get { return _filmDuration; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Value must be a positive number");
                }
                _filmDuration = value;
            }
        }
        public int ReleaseYear
        {
            get { return _releaseYear; }
            set
            {
                if (value <= 1900 | value >= DateTime.Now.Year)
                {
                    throw new ArgumentException("Value must be in range from 1900 to the current year");
                }
                _releaseYear = value;
            }
        }
        public double Rate
        {
            get { return _rate; }
            set
            {
                if (value < 0 | value > 10)
                {
                    throw new ArgumentException("Value must be in range from 0 to 10");
                }
                _rate = value;
            }
        }
        public Film(string filmName, string genre, int filmDuration, int releaseYear, double rate)
        {
            FilmName = filmName;
            Genre = genre;
            FilmDuration = filmDuration;
            ReleaseYear = releaseYear;
            Rate = rate;
        }
        public Film()
        {
            FilmName = "FightClub";
            Genre = "Thriller";
            FilmDuration = 139;
            ReleaseYear = 1999;
            Rate = 8.7;
        }
    }
}
