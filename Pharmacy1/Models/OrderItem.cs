using System;
using System.Collections.Generic;

#nullable disable

namespace Pharmacy1.Models
{
    public partial class OrderItem
    {
        public OrderItem()
        {
            OrderItemToMedicines = new HashSet<OrderItemToMedicine>();
        }

        public int OrderItemId { get; set; }
        public int Quantity { get; set; }
        public decimal ItemPrice { get; set; }
        public int? OrderId { get; set; }

        public virtual Order Order { get; set; }
        public virtual ICollection<OrderItemToMedicine> OrderItemToMedicines { get; set; }
    }
}
