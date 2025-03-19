using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Хранит данные о валидациях, используемых в программе.
    /// </summary>
    internal static class Validator
    {
        /// <summary>
        /// Проверяет, что число положительное, если условие не выполняется, то выбрасывается ArgumentException.
        /// </summary>
        /// <param name="value">Проверяемая строка.</param>
        /// <param name="propertyName">Название свойства в котором был вызван метод.</param>
        public static void AssertOnPositiveValue(int value, string propertyName)
        {
            if (value < 0)
            {
                throw new ArgumentException($"Value must be a positive number in {propertyName}");
            }
        }
        /// <summary>
        /// Проверяет, что число положительное, если условие не выполняется, то выбрасывается ArgumentException.
        /// </summary>
        /// <param name="value">Проверяемая строка.</param>
        /// <param name="propertyName">Название свойства в котором был вызван метод.</param>
        public static void AssertOnPositiveValue(double value, string propertyName)
        {
            if (value < 0)
            {
                throw new ArgumentException($"Value must be a positive number in {propertyName}");
            }
        }
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
                throw new ArgumentOutOfRangeException($"Value must be in range from {min} to {max} in {propertyName}");
            }
        }
        /// <summary>
        /// Проверяет, что число принадлежит промежутку, если условие не выполняется, то выбрасывается ArgumentOutOfRangeException.
        /// </summary>
        /// <param name="value">Проверяемая строка.</param>
        /// <param name="min">Левый предел промежутка.</param>
        /// <param name="max">Правый предел промежутка.</param>
        /// <param name="propertyName">Название свойства, в котором был вызван метод.</param>
        public static void AssertValueInRange(double value, int min, int max, string propertyName)
        {
            if ((value < min) || (value > max))
            {
                throw new ArgumentOutOfRangeException($"Value must be in range from {min} to {max} in {propertyName}");
            }
        }
    }
}
