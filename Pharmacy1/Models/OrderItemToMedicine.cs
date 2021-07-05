using System;
using System.Collections.Generic;

#nullable disable

namespace Pharmacy1.Models
{
    public partial class OrderItemToMedicine
    {
        public int Id { get; set; }
        public int MedId { get; set; }
        public int OrderItemId { get; set; }

        public virtual Medicine Med { get; set; }
        public virtual OrderItem OrderItem { get; set; }
    }
}
