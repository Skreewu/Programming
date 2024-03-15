using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Rectangle
    {
        private double _lengh;
        private double _width;
        private string Colour { get; set; }

        public double Lengh
        {
            get { return _lengh; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Value must be a positive number");
                }
                _lengh = value;
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
        public Rectangle(double lengh, double width, string colour)
        {
            Lengh = lengh;
            Width = width;
            Colour = colour;
        }
        public Rectangle()
        {
            Lengh = 1;
            Width = 1;
            Colour = "White";
        }
    }
}
