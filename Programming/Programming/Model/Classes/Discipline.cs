using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    internal class Discipline
    {
        public string DisciplineName { get; set; }
        private int _assessment;
        private bool _retakenOrNot;

        public int Assessment
        {
            get { return _assessment; }
            set
            {
                Validator.AssertValueInRange(value, 1, 5, nameof(Assessment));
            }
        }

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
