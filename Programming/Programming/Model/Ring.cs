using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Ring
    {
        private double _outerRadius;
        private double _innerRadius;
        public Point2D Center { get; set; }

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
        public double Area
        {
            get
            {
                return Math.PI * Math.Pow(OuterRadius, 2) - Math.PI * Math.Pow(InnerRadius, 2);
            }
        }
        public Ring(double outerRadius, double innerRadius, Point2D center)
        {
            OuterRadius = outerRadius;
            InnerRadius = innerRadius;
            Center = center;
        }
    }
}
