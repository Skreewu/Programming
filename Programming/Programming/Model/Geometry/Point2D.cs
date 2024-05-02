using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Geometry
{
    /// <summary>
    /// Хранит данные о координатах в двухмерном пространстве.
    /// </summary>
    internal class Point2D
    {
        /// <summary>
        /// Координата x.
        /// </summary>
        private double _x;
        /// <summary>
        /// Координата y.
        /// </summary>
        private double _y;

        /// <summary>
        /// Возвращает и задает координату x. Должна состоять из числа от 0 до 500.
        /// </summary>
        public double X
        {
            get { return _x; }
            set
            {
                Validator.AssertValueInRange(value, 0, 500, nameof(X));
                _x = value;
            }
        }
        /// <summary>
        /// Возвращает и задает координату y. Должна состоять из числа от 0 до 400.
        /// </summary>
        public double Y
        {
            get { return _y; }
            set
            {
                Validator.AssertValueInRange(value, 0, 400, nameof(Y));
                _y = value;
            }
        }
        /// <summary>
        /// Создаёт экземпляр класса <see cref="Point2D"/>.
        /// </summary>
        /// <param name="x">Координата x. Должна состоять из числа от 0 до 500.</param>
        /// <param name="y">Координата y. Должна состоять из числа от 0 до 400.</param>
        public Point2D(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
}
