using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о дисциплине и оценке по ней.
    /// </summary>
    internal class Discipline
    {
        /// <summary>
        /// Возвращает и задает название дисциплины.
        /// </summary>
        public string DisciplineName { get; set; }
        /// <summary>
        /// Оценка по дисциплине.
        /// </summary>
        private int _assessment;
        /// <summary>
        /// Пересдана дисциплина или нет.
        /// </summary>
        private bool _retakenOrNot;

        /// <summary>
        /// Возвращает и задает оценку по дисциплине. Должна состоять из цифры от 1 до 5.
        /// </summary>
        public int Assessment
        {
            get { return _assessment; }
            set
            {
                Validator.AssertValueInRange(value, 1, 5, nameof(Assessment));
            }
        }

        /// <summary>
        /// Возвращает и задает пересдана ли дисциплина или нет. Должна быть типа данных bool.
        /// </summary>
        public bool RetakenOrNot
        {
            get { return _retakenOrNot; }
            set
            {
                if (value != true && value != false)
                {
                    throw new ArgumentException("The value must be 'true' or 'false'");
                }
                _retakenOrNot = value;
            }
        }
        /// <summary>
        /// Создаёт экземпляр класса <see cref="Discipline"/>.
        /// </summary>
        /// <param name="disciplinename">Название дисциплины.</param>
        /// <param name="assessment">Оценка по дисциплине.</param>
        /// <param name="retakenOrNot">Пересдана или нет. Должна быть типа данных bool.</param>
        public Discipline(string disciplinename, int assessment, bool retakenOrNot)
        {
            DisciplineName = disciplinename;
            Assessment = assessment;
            RetakenOrNot = retakenOrNot;
        }
        public Discipline()
        {
            DisciplineName = "Alex";
            Assessment = 5;
            RetakenOrNot = false;
        }
    }
}
