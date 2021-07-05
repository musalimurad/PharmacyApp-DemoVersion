using System;
using System.Collections.Generic;

#nullable disable

namespace Pharmacy1.Models
{
    public partial class MedicineToTag
    {
        public int Id { get; set; }
        public int MedicineId { get; set; }
        public int TagId { get; set; }

        public virtual Medicine Medicine { get; set; }
        public virtual Tag Tag { get; set; }
    }
}
