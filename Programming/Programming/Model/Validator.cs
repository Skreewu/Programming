using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal static class Validator
    {
        public static void AssertOnPositiveValue(int value, string propertyName)
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException($"Value must be a positive number in {propertyName}");
            }
        }
        public static void AssertOnPositiveValue(double value, string propertyName)
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException($"Value must be a positive number in {propertyName}");
            }
        }
        public static void AssertValueInRange(int value, int min, int max, string propertyName)
        {
            if ((value < min) || (value > max))
            {
                throw new ArgumentOutOfRangeException($"Value must be in range from {min} to {max} in {propertyName}");
            }
        }
        public static void AssertValueInRange(double value, int min, int max, string propertyName)
        {
            if ((value < min) || (value > max))
            {
                throw new ArgumentOutOfRangeException($"Value must be in range from {min} to {max} in {propertyName}");
            }
        }
    }
}
