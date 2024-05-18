using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AirTravelList
{
    /// <summary>
    /// Хранит данные о полете.
    /// </summary>
    [DataContract]
    internal class Flight : IComparable<Flight>
    {
        /// <summary>
        /// Пункт отправления.
        /// </summary>
        private string _departurePoint;
        /// <summary>
        /// Пункт назначения.
        /// </summary>
        private string _destination;
        /// <summary>
        /// Время вылета.
        /// </summary>
        private DateTime _departureTime;
        /// <summary>
        /// Время полета.
        /// </summary>
        private int _flightTime;
        /// <summary>
        /// Тип рейса.
        /// </summary>
        [DataMember]
        public TypesOfFlight TypeOfFlight { get; set; }

        [DataMember]
        public string DeparturePoint
        {
            get { return _departurePoint; }
            set
            {
                Validator.MaximumStringLength(value, 100, nameof(DeparturePoint));
                _departurePoint = value;
            }
        }
        [DataMember]
        public string Destination
        {
            get { return _destination; }
            set
            {
                Validator.MaximumStringLength(value, 100, nameof(Destination));
                _destination = value;
            }
        }
        [DataMember]
        public DateTime DepartureTime
        {
            get { return _departureTime; }
            set
            {
                _departureTime = value;
            }
        }
        /// <summary>
        /// Задает и возвращает данные о времени полета. Должно состоять только из цифр.
        /// </summary>
        [DataMember]
        public int FlightTime
        {
            get { return _flightTime; }
            set
            {
                Validator.AssertValueInRange(value, 0, 1000, nameof(FlightTime));
                _flightTime = value;
            }
        }
        /// <summary>
        /// Создаёт экземпляр класса <see cref="Flight"/>.
        /// </summary>
        /// <param name="departurePoint">Пункт направления.</param>
        /// <param name="destination">Пункт назначения.</param>
        /// <param name="flightTime">Время полета. Должно состоять только из цифр.</param>
        public Flight(string departurePoint, string destination, int flightTime, DateTime departureTime, TypesOfFlight typeOfFligth)
        {
            DeparturePoint = departurePoint;
            Destination = destination;
            FlightTime = flightTime;
            DepartureTime = departureTime;
            TypeOfFlight = typeOfFligth;
        }
        public Flight()
        {
            DeparturePoint = "Пункт отправления";
            Destination = "Пункт назначения";
            FlightTime = 0;
            DepartureTime = DateTime.Now;
            TypeOfFlight = TypesOfFlight.International;
        }
        /// <summary>
        /// Позволяет выводить данные о рейсе в удобной форме.
        /// </summary>
        /// <returns>Возвращает данные о рейсе в более удобной форме.</returns>
        public override string ToString()
        {
            return $"{DepartureTime.Day}.{DepartureTime.Month}.{DepartureTime.Year}: {DeparturePoint} - {Destination}";
        }
        public int CompareTo(Flight other)
        {
            return DepartureTime.CompareTo(other.DepartureTime);
        }
        public string ToStringForFile()
        {
            return $"{DeparturePoint},{Destination},{FlightTime},{DepartureTime},{TypeOfFlight}";
        }
    }
}
