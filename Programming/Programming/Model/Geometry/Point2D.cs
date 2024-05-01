using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Geometry
{
    internal class Point2D
    {
        private double _x;
        private double _y;

        public double X
        {
            get { return _x; }
            set
            {
                Validator.AssertValueInRange(value, 0, 500, nameof(X));
                _x = value;
            }
        }
        public double Y
        {
            get { return _y; }
            set
            {
                Validator.AssertValueInRange(value, 0, 400, nameof(Y));
                _y = value;
            }
        }

        public Point2D(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
}
