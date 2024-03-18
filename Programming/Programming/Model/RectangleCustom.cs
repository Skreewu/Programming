using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class RectangleCustom
    {
        private double _length;
        private double _width;
        public Colour Color { get; set; }

        public double Length
        {
            get { return _length; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Value must be a positive number");
                }
                _length = value;
            }
        }
        public double Width
        {
            get { return _width; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Value must be a positive number");
                }
                _width = value;
            }
        }
        public RectangleCustom(double length, double width, Colour color)
        {
            Length = length;
            Width = width;
            Color = color;
        }
        public RectangleCustom()
        {
            Length = 1;
            Width = 1;
            Color = Colour.White;
        }
        public override string ToString()
        {
            return $"Rectangle {Length}x{Width}";
        }
    }
}
