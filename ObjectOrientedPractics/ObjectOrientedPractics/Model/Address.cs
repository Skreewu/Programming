using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные об адресе.
    /// </summary>
    public class Address
    {
        /// <summary>
        /// Почтовый индекс.
        /// </summary>
        private int _index;
        /// <summary>
        /// Страна.
        /// </summary>
        private string _country;
        /// <summary>
        /// Населенный пункт.
        /// </summary>
        private string _city;
        /// <summary>
        /// Улица.
        /// </summary>
        private string _street;
        /// <summary>
        /// Номер дома.
        /// </summary>
        private string _building;
        /// <summary>
        /// Номер квартиры/помещения
        /// </summary>
        private string _apartment;

        /// <summary>
        /// Задает и возвращает почтовый индекс. Должен быть целым шестизначным числом.
        /// </summary>
        public int Index
        {
            get { return _index; }
            set
            {
                ValueValidator.AssertValueInRange(value, 100000, 999999, nameof(Index));
                _index = value;
            }
        }
        /// <summary>
        /// Задает и возвращает страну. Не больше 50 символов.
        /// </summary>
        public string Country
        {
            get { return _country; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 50, nameof(Country));
                _country = value;
            }
        }
        /// <summary>
        /// Задает и возвращает город. Не больше 50 символов.
        /// </summary>
        public string City
        {
            get { return _city; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 50, nameof(City));
                _city = value;
            }
        }
        /// <summary>
        /// Задает и возвращает улицу. Не больше 100 символов.
        /// </summary>
        public string Street
        {
            get { return _street; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 100, nameof(Street));
                _street = value;
            }
        }
        /// <summary>
        /// Задает и возвращает номер дома. Не больше 10 символов.
        /// </summary>
        public string Building
        {
            get { return _building; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 10, nameof(Building));
                _building = value;
            }
        }
        /// <summary>
        /// Задает и возвращает номер квартиры. Не больше 10 символов.
        /// </summary>
        public string Apartment
        {
            get { return _apartment; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 10, nameof(Apartment));
                _apartment = value;
            }
        }
        /// <summary>
        /// Создает экземпляр класса <see cref="Address"/>
        /// </summary>
        /// <param name="index">Почтовый индекс. Целое шестизначное число.</param>
        /// <param name="country">Страна. Не больше 50 символов.</param>
        /// <param name="city">Город. Не больше 50 символов.</param>
        /// <param name="street">Улица. Не больше 100 символов.</param>
        /// <param name="building">Номер дома. Не больше 10 символов.</param>
        /// <param name="apartment">Номер квартиры. Не больше 10 символов</param>
        public Address(int index, string country, string city, string street, string building, string apartment)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            Building = building;
            Apartment = apartment;
        }
        /// <summary>
        /// Конструктор по умолчанию. Создает экземпляр класса <see cref="Address"/>
        /// </summary>
        public Address()
        {
            Index = 100000;
            Country = "Страна";
            City = "Город";
            Street = "Улица";
            Building = "0";
            Apartment = "0";
        }
        /// <summary>
        /// Позволяет выводить информацию об объекте класса в более удобной форме.
        /// </summary>
        /// <returns>Возвращает преобразование в строку.</returns>
        public override string ToString()
        {
            return $"ул. {Street}, д.{Building}, кв.{Apartment}, г.{City}";
        }
    }
}
