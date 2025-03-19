using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Geometry
{
    /// <summary>
    /// Хранит данные о прямоугольнике.
    /// </summary>
    internal class RectangleCustom
    {
        /// <summary>
        /// Длина прямоугольника.
        /// </summary>
        private double _length;
        /// <summary>
        /// Ширина прямоугольника.
        /// </summary>
        private double _width;
        /// <summary>
        /// Возвращает и задает цвет прямоугольника.
        /// </summary>
        public Colour Color { get; set; }
        /// <summary>
        /// Возвращает и задает координаты центра прямоугольника.
        /// </summary>
        public Point2D Center { get; set; }
        /// <summary>
        /// Уникальный идентификатор для всех объектов данного класса.
        /// </summary>
        private readonly int _id;
        /// <summary>
        /// Количество прямоугольников.
        /// </summary>
        private static int _allRectanglesCount;

        /// <summary>
        /// Возвращает и задает длину прямоугольника. Должна состоять только из цифр.
        /// </summary>
        public double Length
        {
            get { return _length; }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Length));
                _length = value;
            }
        }
        /// <summary>
        /// Возвращает и задает ширину прямоугольника. Должна состоять только из цифр.
        /// </summary>
        public double Width
        {
            get { return _width; }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Width));
                _width = value;
            }
        }
        /// <summary>
        /// Возвращает количество прямоугольников.
        /// </summary>
        public static int AllRectanglesCount
        {
            get { return _allRectanglesCount; }
        }
        /// <summary>
        /// Возвращает уникальный идентификатор для всех объектов данного класса.
        /// </summary>
        public int Id
        {
            get { return _id; }
        }
        /// <summary>
        /// Создаёт экземпляр класса <see cref="RectangleCustom"/>.
        /// </summary>
        /// <param name="length">Длина прямоугольника. Должна состоять только из цифр.</param>
        /// <param name="width">Ширина прямоугольника. Должна состоять только из цифр.</param>
        /// <param name="color">Цвет прямоугольника.</param>
        /// <param name="center">Координаты центра.</param>
        public RectangleCustom(double length, double width, Colour color, Point2D center)
        {
            Length = length;
            Width = width;
            Color = color;
            Center = center;
            _id = _allRectanglesCount;
            _allRectanglesCount++;
        }
        public RectangleCustom()
        {
            Length = 1;
            Width = 1;
            Color = Colour.White;
            Center = new Point2D(0, 0);
        }
        /// <summary>
        /// Позволяет выводить данные о прямоугольнике в удобной форме.
        /// </summary>
        /// <returns>Возвращает данные о прямоугольнике в более удобной форме.</returns>
        public override string ToString()
        {
            return $"{Length}x{Width}, X={Center.X}, Y={Center.Y}";
        }
    }
}
