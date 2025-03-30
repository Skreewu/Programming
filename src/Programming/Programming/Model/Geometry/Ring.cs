using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Geometry
{
    /// <summary>
    /// Хранит данные о кольце.
    /// </summary>
    internal class Ring
    {
        /// <summary>
        /// Внешний радиус кольца.
        /// </summary>
        private double _outerRadius;
        /// <summary>
        /// Внутренний радиус кольца.
        /// </summary>
        private double _innerRadius;
        /// <summary>
        /// Возвращает и задает координаты центра.
        /// </summary>
        public Point2D Center { get; set; }

        /// <summary>
        /// Возвращает и задает внешний радиус. Должен содержать только цифры. Не может быть меньше внутреннего радиуса.
        /// </summary>
        public double OuterRadius
        {
            get { return _outerRadius; }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(OuterRadius));
                if (OuterRadius < InnerRadius)
                {
                    throw new ArgumentOutOfRangeException("The outer radius must be larger than inner one");
                }
                _outerRadius = value;
            }
        }
        /// <summary>
        /// Возвращает и задает внутренний радиус. Должен содержать только цифры. Не может быть больше внешнего радиуса.
        /// </summary>
        public double InnerRadius
        {
            get { return _innerRadius; }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(InnerRadius));
                if (InnerRadius > OuterRadius)
                {
                    throw new ArgumentOutOfRangeException("The outer radius must be larger than inner one");
                }
                _innerRadius = value;
            }
        }
        /// <summary>
        /// Возвращает площадь кольца.
        /// </summary>
        public double Area
        {
            get
            {
                return Math.PI * Math.Pow(OuterRadius, 2) - Math.PI * Math.Pow(InnerRadius, 2);
            }
        }
        /// <summary>
        /// Создаёт экземпляр класса <see cref="Ring"/>.
        /// </summary>
        /// <param name="outerRadius">Внешний радиус. Должен содержать только цифры. Не может быть меньше внутреннего радиуса.</param>
        /// <param name="innerRadius">Внутренний радиус. Должен содержать только цифры. Не может быть больше внешнего радиуса.</param>
        /// <param name="center">Координаты центра кольца.</param>
        public Ring(double outerRadius, double innerRadius, Point2D center)
        {
            OuterRadius = outerRadius;
            InnerRadius = innerRadius;
            Center = center;
        }
    }
}
