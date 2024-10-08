using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    class IdGenerator
    {
        private int _currentId;

        public IdGenerator()
        {
            _currentId = -1;
        }

        public int GetNextId()
        {
            return _currentId++;
        }
        
        public void SetId(int count)
        {
            _currentId += count;
        }
    }
}
