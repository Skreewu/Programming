using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    [DataContract]
    internal class Order
    {
        private static IdGenerator idGenerator = new IdGenerator();
        [DataMember]
        public int Id {  get; private set; }
        [DataMember]
        public DateTime OrderCreationDate { get; private set; }
        [DataMember]
        public OrderStatus Status { get; set; }
        private Address _adress;
        private List<Item> _items;
        private double _amount;

        [DataMember]
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
        [DataMember]
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
                _amount = 0;
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
            Status = 0;  
        }
        public Order(Address address, List<Item> items)
        {
            Id = idGenerator.GetNextId();
            OrderCreationDate = DateTime.Now;
            Items = items;
            Address = address;
            Status = 0;
        }
    }
}
