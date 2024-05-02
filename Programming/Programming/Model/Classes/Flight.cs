using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о полете.
    /// </summary>
    internal class Flight
    {
        /// <summary>
        /// Задает и возвращает данные о пункте отправления.
        /// </summary>
        public string DeparturePoint { get; set; }
        /// <summary>
        /// Задает и возвращает данные о пункте направления.
        /// </summary>
        public string Destination { get; set; }
        /// <summary>
        /// Время полета.
        /// </summary>
        private int _flightTime;

        /// <summary>
        /// Задает и возвращает данные о времени полета. Должно состоять только из цифр.
        /// </summary>
        public int FlightTime
        {
            get { return _flightTime; }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(FlightTime));
                _flightTime = value;
            }
        }
        /// <summary>
        /// Создаёт экземпляр класса <see cref="Flight"/>.
        /// </summary>
        /// <param name="departurePoint">Пункт направления.</param>
        /// <param name="destination">Пункт Назначения.</param>
        /// <param name="flightTime">Время полета. Должно состоять только из цифр.</param>
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
