using System;
using System.Collections.Generic;

#nullable disable

namespace Pharmacy1.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderItems = new HashSet<OrderItem>();
        }

        public int OrderId { get; set; }
        public decimal? TotalPrice { get; set; }
        public DateTime? SaleDate { get; set; }
        public int? AdminId { get; set; }

        public virtual Admin Admin { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
