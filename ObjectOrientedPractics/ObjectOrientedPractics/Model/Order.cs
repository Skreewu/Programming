using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    internal class Order
    {
        private static IdGenerator idGenerator = new IdGenerator();
        public int Id {  get; private set; }
        public DateTime OrderCreationDate { get; }
        private Address _adress;
        private List<Item> _items;
        private double _amount;

        public Address Address
        {
            get 
            { 
                return _adress; 
            }
            set 
            { 
                _adress = value; 
            }
        }
        public List<Item> Items
        {
            get
            {
                return _items;
            }
            set
            {
                _items = value;
            }
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
        public Order()
        {
            Id = idGenerator.GetNextId();
            OrderCreationDate = DateTime.Now;
            Items = new List<Item>();
            Address = new Address();
        }
    }
}
