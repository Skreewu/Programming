using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    internal class Flight
    {
        public string DeparturePoint { get; set; }
        public string Destination { get; set; }
        private int _flightTime;

        public int FlightTime
        {
            get { return _flightTime; }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(FlightTime));
                _flightTime = value;
            }
        }
        public Flight(string departurePoint, string destination, int flightTime)
        {
            DeparturePoint = departurePoint;
            Destination = destination;
            FlightTime = flightTime;
        }
        public Flight()
        {
            DeparturePoint = "Tomsk";
            Destination = "Krasnoyarsk";
            FlightTime = 90;
        }
    }
}
