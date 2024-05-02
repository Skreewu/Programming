using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о фильме.
    /// </summary>
    internal class Film
    {
        /// <summary>
        /// Возвращает и задает название фильма.
        /// </summary>
        public string FilmName { get; set; }
        /// <summary>
        /// Возвращает и задает жанр фильма.
        /// </summary>
        public string Genre { get; set; }
        /// <summary>
        /// Продолжительность.
        /// </summary>
        private int _filmDuration;
        /// <summary>
        /// Год выпуска.
        /// </summary>
        private int _releaseYear;
        /// <summary>
        /// Оценка.
        /// </summary>
        private double _rate;

        /// <summary>
        /// Возвращает и задает продолжительность фильма. Должна состоять только из цифр.
        /// </summary>
        public int FilmDuration
        {
            get { return _filmDuration; }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(FilmDuration));
                _filmDuration = value;
            }
        }
        /// <summary>
        /// Возвращает и задает год выпуска. Должен состоять из числа от 1900 до 2024.
        /// </summary>
        public int ReleaseYear
        {
            get { return _releaseYear; }
            set
            {
                Validator.AssertValueInRange(value, 1900, 2024, nameof(ReleaseYear));
                _releaseYear = value;
            }
        }
        /// <summary>
        /// Возвращает и задает оценку фильма. Должна состоять из числа от 0 до 10.
        /// </summary>
        public double Rate
        {
            get { return _rate; }
            set
            {
                Validator.AssertValueInRange(value, 0, 10, nameof(Rate));
                _rate = value;
            }
        }
        /// <summary>
        /// Создаёт экземпляр класса <see cref="Film"/>.
        /// </summary>
        /// <param name="filmName">Название фильма.</param>
        /// <param name="genre">Жанр фильма.</param>
        /// <param name="filmDuration">Продолжительность фильма. Доллжна состоять только из фильма.</param>
        /// <param name="releaseYear">Год выпуска. Должен состоять из числа от 1900 до 2024.</param>
        /// <param name="rate">Оценка фильма. Должна состоять из числа от 0 до 10.</param>
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
        /// <summary>
        /// Позволяет выводить только название фильма.
        /// </summary>
        /// <returns>Возвращает название фильма.</returns>
        public override string ToString()
        {
            return $"{FilmName}";
        }
    }
}
