using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    [DataContract]
    internal class Cart
    {
        private List<Item> _items;
        private double _amount;

        [DataMember]
        public List<Item> Items
        {
            get { return _items; }
            set { _items = value; }
        }
        public double Amount
        {
            get
            {
                _amount = 0;
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
            Items = new List<Item>();
        }
    }
}
