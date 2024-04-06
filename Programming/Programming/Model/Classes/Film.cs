using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    internal class Film
    {
        public string FilmName { get; set; }
        public string Genre { get; set; }
        private int _filmDuration;
        private int _releaseYear;
        private double _rate;

        public int FilmDuration
        {
            get { return _filmDuration; }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(FilmDuration));
                _filmDuration = value;
            }
        }
        public int ReleaseYear
        {
            get { return _releaseYear; }
            set
            {
                Validator.AssertValueInRange(value, 1900, 2024, nameof(ReleaseYear));
                _releaseYear = value;
            }
        }
        public double Rate
        {
            get { return _rate; }
            set
            {
                Validator.AssertValueInRange(value, 0, 10, nameof(Rate));
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
        public override string ToString()
        {
            return $"{FilmName}";
        }
    }
}
