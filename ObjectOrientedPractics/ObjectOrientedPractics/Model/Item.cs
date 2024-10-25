using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о товаре.
    /// </summary>
    [DataContract]
    internal class Item
    {
        private static IdGenerator idGenerator = new IdGenerator();
        /// <summary>
        /// Возвращает ID товара.
        /// </summary>
        [DataMember]
        public int Id { get; private set; }
        /// <summary>
        /// Название товара.
        /// </summary>
        private string _name;
        /// <summary>
        /// Информация о товаре.
        /// </summary>
        private string _info;
        /// <summary>
        /// Стоимость.
        /// </summary>
        private double _cost;
        /// <summary>
        /// Задает и возвращает категорию товара.
        /// </summary>
        [DataMember]
        public Category Category { get; set; }

        /// <summary>
        /// Задает и возвращает данные о названии товара. Не больше 200 символов.
        /// </summary>
        [DataMember]
        public string Name
        {
            get { return _name; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 200, nameof(Name));
                _name = value;
            }
        }
        /// <summary>
        /// Задает и возвращает информацию о товаре. Не больше 1000 символов.
        /// </summary>
        [DataMember]
        public string Info
        {
            get { return _info; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 1000, nameof(Name));
                _info = value;
            }
        }
        /// <summary>
        /// Задает и возвращает стоимость товара. От 0 до 100 000.
        /// </summary>
        [DataMember]
        public double Cost
        {
            get { return _cost; }
            set
            {
                ValueValidator.AssertValueInRange(value, 0, 100000, nameof(Cost));
                _cost = value;
            }
        }
        /// <summary>
        /// Создаёт экземпляр класса <see cref="Item"/>.
        /// </summary>
        /// <param name="name">Название товара. Не больше 200 символов.</param>
        /// <param name="info">Инфорация о товаре. Не больше 1000 символов.</param>
        /// <param name="cost">Стоимость. От 0 до 100 000.</param>
        /// <param name="category">Категория товара.</param>
        public Item(string name, string info, double cost, Category category)
        {
            Id = idGenerator.GetNextId();
            Name = name;
            Info = info;
            Cost = cost;;
            Category = category;
        }
        /// <summary>
        /// Конструктор по умолчанию, создает экземпляр класса <see cref="Item"/>
        /// </summary>
        public Item()
        {
            Id = idGenerator.GetNextId();
            Name = "Название";
            Info = "Описание";
            Cost = 0;
            Category = Category.Food;
        }
        /// <summary>
        /// Позволяет выводить информацию об объекте класса в более удобной форме.
        /// </summary>
        /// <returns>Возвращает преобразование в строку.</returns>
        public override string ToString()
        {
            return $"{Name} - {Cost}р.";
        }
        public static void SetId(int value)
        {
            idGenerator.SetId(value);
        }
    }
}
