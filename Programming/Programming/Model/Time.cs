using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Time
    {
        private int _hours;
        private int _minutes;
        private int _seconds;

        public int Hours
        {
            get { return _hours; }
            set
            {
                if (value < 0 | value > 23)
                {
                    throw new ArgumentException("Value must be in range from 0 to 23");
                }
                _hours = value;
            }
        }
        public int Minutes
        {
            get { return _minutes; }
            set
            {
                if (value < 0 | value > 60)
                {
                    throw new ArgumentException("Value must be in range from 0 to 60");
                }
                _minutes = value;
            }
        }
        public int Seconds
        {
            get { return _seconds; }
            set
            {
                if (value < 0 | value > 60)
                {
                    throw new ArgumentException("Value must be in range from 0 to 60");
                }
                _seconds = value;
            }
        }
        public Time(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }
        public Time()
        {
            Hours = 17;
            Minutes = 44;
            Seconds = 13;
        }
    }
}
