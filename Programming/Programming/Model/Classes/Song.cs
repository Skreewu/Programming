using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о композиции.
    /// </summary>
    internal class Song
    {
        /// <summary>
        /// Возвращает и задает имя артиста или музыкальной группы.
        /// </summary>
        public string Artist { get; set; }
        /// <summary>
        /// Возвращает и задает название композиции.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Возвращает и задает жанр.
        /// </summary>
        public string Genre { get; set; }
        /// <summary>
        /// Длительность композиции.
        /// </summary>
        private int _songDuration;

        /// <summary>
        /// Возвращает и задает продолжительность композиции. Должна состоять только из цифр.
        /// </summary>
        public int SongDuration
        {
            get { return _songDuration; }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(SongDuration));
                _songDuration = value;
            }
        }
        /// <summary>
        /// Создаёт экземпляр класса <see cref="Song"/>.
        /// </summary>
        /// <param name="artist">Имя артиста.</param>
        /// <param name="name">Название композиции.</param>
        /// <param name="genre">Жанр композиции.</param>
        /// <param name="songDuration">Продрожительность композиции. Должна состоять только из цифр.</param>
        public Song(string artist, string name, string genre, int songDuration)
        {
            Artist = artist;
            Name = name;
            Genre = genre;
            SongDuration = songDuration;
        }
        public Song()
        {
            Artist = "Linkin Park";
            Name = "Breaking the Habit";
            Genre = "Alternative Rock";
            SongDuration = 196;
        }
    }
}
