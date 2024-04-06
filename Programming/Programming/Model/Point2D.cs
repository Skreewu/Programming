using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Point2D
    {
        private readonly double _x;
        private readonly double _y;

        public double X
        {
            get { return _x; }
            private set
            {
                Validator.AssertOnPositiveValue(_x, nameof(X));
                Validator.AssertValueInRange(_x, -100, 100, nameof(X));
            }
        }
        public double Y
        {
            get { return _y; }
            private set
            {
                Validator.AssertOnPositiveValue(_y, nameof(Y));
                Validator.AssertValueInRange(_y, -100, 100, nameof(Y));
            }
        }

        public Point2D(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
}
