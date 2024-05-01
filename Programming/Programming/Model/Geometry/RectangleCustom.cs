using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Geometry
{
    internal class RectangleCustom
    {
        private double _length;
        private double _width;
        public Colour Color { get; set; }
        public Point2D Center { get; set; }
        private readonly int _id;
        private static int _allRectanglesCount;

        public double Length
        {
            get { return _length; }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Length));
                _length = value;
            }
        }
        public double Width
        {
            get { return _width; }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Width));
                _width = value;
            }
        }
        public static int AllRectanglesCount
        {
            get { return _allRectanglesCount; }
        }
        public int Id
        {
            get { return _id; }
        }
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
        public override string ToString()
        {
            return $"{Length}x{Width}, X={Center.X}, Y={Center.Y}";
        }
    }
}
