using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTravelList
{
    /// <summary>
    /// Хранит данные о валидациях, используемых в программе.
    /// </summary>
    internal static class Validator
    {
        /// <summary>
        /// Проверяет, что число принадлежит промежутку, если условие не выполняется, то выбрасывается ArgumentOutOfRangeException.
        /// </summary>
        /// <param name="value">Проверяемая строка.</param>
        /// <param name="min">Левый предел промежутка.</param>
        /// <param name="max">Правый предел промежутка.</param>
        /// <param name="propertyName">Название свойства, в котором был вызван метод.</param>
        public static void AssertValueInRange(int value, int min, int max, string propertyName)
        {
            if ((value < min) || (value > max))
            {
                throw new ArgumentException($"Value must be in range from {min} to {max} in {propertyName}");
            }
        }
        /// <summary>
        /// Проверяет, что строка ограничена по количеству символов, если условие не выполняется, то выбрасывается ArgumentOutOfRangeException.
        /// </summary>
        /// <param name="value">Проверяемая строка.</param>
        /// <param name="maxLength">Максимально допустимая длина строки.</param>
        /// <param name="propertyName">Название свойства, в котором был вызван метод.</param>
        public static void MaximumStringLenght(string value, int maxLength, string propertyName)
        {
            if (value.Length > maxLength)
            {
                throw new ArgumentException($"The value must contain less than {maxLength} characters per line");
            }
        }
        /// <summary>
        /// Проверяет, что некоторое значение типа DateTime не может быть установлено раньше сегодняшнего дня, если условие не выполняется, то выбрасывается ArgumentOutOfRangeException.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="propertyName">Название свойства, в котором был вызван метод.</param>
        public static void DateTimeValueValidator(DateTime value, string propertyName)
        {
            if (value < DateTime.Now)
            {
                throw new ArgumentException("The departure time must be no earlier than today");
            }
        }
    }
}
