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
        /// Задает и возвращает тип рейса.
        /// </summary>
        [DataMember]
        public TypesOfFlight TypeOfFlight { get; set; }

        /// <summary>
        /// Задает и возвращает данные о пункте отправления. Не должно быть больше 100 символов.
        /// </summary>
        [DataMember]
        public string DeparturePoint
        {
            get { return _departurePoint; }
            set
            {
                Validator.MaximumStringLenght(value, 100, nameof(DeparturePoint));
                _departurePoint = value;
            }
        }
        /// <summary>
        /// Задает и возвращает данные о пункте назначения. Не должно быть больше 100 символов.
        /// </summary>
        [DataMember]
        public string Destination
        {
            get { return _destination; }
            set
            {
                Validator.MaximumStringLenght(value, 100, nameof(Destination));
                _destination = value;
            }
        }
        /// <summary>
        /// Задает и возвращает данные о времени вылета.
        /// </summary>
        [DataMember]
        public DateTime DepartureTime
        {
            get { return _departureTime; }
            set
            {
                Validator.DateTimeValueValidator(value, nameof(DepartureTime));
                _departureTime = value;
            }
        }
        /// <summary>
        /// Задает и возвращает данные о времени полета. Должно состоять из числа от 0 до 1000.
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
        /// <param name="flightTime">Время полета. Должно состоять из числа от 0 до 1000.</param>
        /// <param name="departurePoint">Время вылета. Объект типа DateTime.</param>
        /// <param name="typeOfFligth">Тип рейса.</param>
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
            DepartureTime = DateTime.MaxValue;
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
        /// <summary>
        /// Задает критерий для сортировки.
        /// </summary>
        /// <returns>Возвращает либо -1, что означает, что текущий объект меньше другого, либо 1, что означает, что текущий объект больше другого, либо 0 когда объекты равны.</returns>
        public int CompareTo(Flight other)
        {
            return DepartureTime.CompareTo(other.DepartureTime);
        }
    }
}
