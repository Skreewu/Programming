using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    internal class PriorityOrder : Order
    {
        private static IdGenerator idGenerator = new IdGenerator();
        /// <summary>
        /// Задает и возвращает желаемую дату доставки.
        /// </summary>
        public DateTime DesiredDeliveryDate { get; set; }
        /// <summary>
        /// Задает и возвращает желаемое время доставки.
        /// </summary>
        public DeliveryTimeSlot DesiredDeliveryTimeSlot { get; set; }
        public PriorityOrder(bool isId) : base(isId)
        {
        }

        public PriorityOrder(Address address, List<Item> items, bool isId) : base(address, items, isId)
        {
            DesiredDeliveryDate = DateTime.MaxValue;
            DesiredDeliveryTimeSlot = 0;
        }
    }
}
