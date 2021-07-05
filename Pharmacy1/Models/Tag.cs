using System;
using System.Collections.Generic;

#nullable disable

namespace Pharmacy1.Models
{
    public partial class Tag
    {
        public Tag()
        {
            MedicineToTags = new HashSet<MedicineToTag>();
        }

        public int TagId { get; set; }
        public string TagName { get; set; }

        public virtual ICollection<MedicineToTag> MedicineToTags { get; set; }
    }
}
