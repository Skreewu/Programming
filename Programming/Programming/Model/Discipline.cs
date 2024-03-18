using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
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
                if (value < 1 | value > 5)
                {
                    throw new ArgumentException("Value must be in range from 1 to 5");
                }
                _assessment = value;
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
