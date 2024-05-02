using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Хранит данные о цветах, используемых в программе.
    /// </summary>
    internal class AppColors
    {
        /// <summary>
        /// Цвет, используемый в отрисовке зеленых прямоугольников.
        /// </summary>
        public static Color greenRectangle = Color.FromArgb(127, 127, 255, 127);
        /// <summary>
        /// Цвет, используемый при ошибках и пересекающихся прямоугольниках.
        /// </summary>
        public static Color errors = Color.LightPink;
        /// <summary>
        /// Белый цвет.
        /// </summary>
        public static Color basicWhite = Color.White;
    }
}
