using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Хранит данные о валидациях, используемых в программе.
    /// </summary>
    internal static class ValueValidator
    {
        /// <summary>
        /// Проверяет, что длина строки не превышает определенное значение, если условие не выполняется, то выбрасывается ArgumentException.
        /// </summary>
        /// <param name="value">Проверяемая строка.</param>
        /// <param name="maxLength">Максимальная длина строки.</param>
        /// <param name="propertyName">Название свойства, в котором был вызван метод.</param>
        public static void AssertStringOnLength(string value, int maxLength, string propertyName)
        {
            if (value.Length > maxLength)
            {
                throw new ArgumentException($"{propertyName} must be less than {maxLength} characters in length");
            }
        }
        /// <summary>
        /// Проверяет, что число принадлежит промежутку, если условие не выполняется, то выбрасывается ArgumentException.
        /// </summary>
        /// <param name="value">Проверяемая строка.</param>
        /// <param name="min">Левый предел промежутка.</param>
        /// <param name="max">Правый предел промежутка.</param>
        /// <param name="propertyName">Название свойства, в котором был вызван метод.</param>
        public static void AssertValueInRange(double value, double min, double max, string propertyName)
        {
            if ((value < min) || (value > max))
            {
                throw new ArgumentException($"{propertyName} must be in range from {min} to {max}");
            }
        }
    }
}
