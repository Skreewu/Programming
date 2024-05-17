using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о времени в часах, минутах и секундах.
    /// </summary>
    internal class Time
    {
        /// <summary>
        /// Поле, обозначающее часы.
        /// </summary>
        private int _hours;
        /// <summary>
        /// Поле, обозначающее минуты.
        /// </summary>
        private int _minutes;
        /// <summary>
        /// Поле, обозначающее секунды.
        /// </summary>
        private int _seconds;

        /// <summary>
        /// Возвращает и задает час. Должен состоять только из числа от 0 до 23.
        /// </summary>
        public int Hours
        {
            get { return _hours; }
            set
            {
                Validator.AssertValueInRange(value, 0, 23, nameof(Hours));
                _hours = value;
            }
        }
        /// <summary>
        /// Возвращает и задает минуты. Должна состоять только из числа от 0 до 60.
        /// </summary>
        public int Minutes
        {
            get { return _minutes; }
            set
            {
                Validator.AssertValueInRange(value, 0, 60, nameof(Minutes));
                _minutes = value;
            }
        }
        /// <summary>
        /// Возвращает и задает секунды. Должна состоять только из числа от 0 до 60.
        /// </summary>
        public int Seconds
        {
            get { return _seconds; }
            set
            {
                Validator.AssertValueInRange(value, 0, 60, nameof(Seconds));
                _seconds = value;
            }
        }
        /// <summary>
        /// Создаёт экземпляр класса <see cref="Time"/>.
        /// </summary>
        /// <param name="hours">Час. Должен состоять только чисел от 0 до 23.</param>
        /// <param name="minutes">Минуты. Должны состоять только из чисел от 0 до 60.</param>
        /// <param name="seconds">Секунды. Должны состоять только из числе от 0 до 60.</param>
        public Time(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }
        public Time()
        {
            Hours = 17;
            Minutes = 44;
            Seconds = 13;
        }
    }
}
