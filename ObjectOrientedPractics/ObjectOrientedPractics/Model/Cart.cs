using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    internal class Cart
    {
        private List<Item> _items;
        private double _amount;

        public List<Item> Items
        {
            get { return _items; }
            set { _items = value; }
        }
        public double Amount
        {
            get
            {
                if (_items == null || _items.Count == 0) return 0;
                for (int i = 0; i < _items.Count; i++)
                {
                    _amount += _items[i].Cost;
                }
                return _amount;
            }
        }
        public Cart()
        {
            List<Item> items = new List<Item>();
        }
    }
}
