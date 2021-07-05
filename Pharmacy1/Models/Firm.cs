using System;
using System.Collections.Generic;

#nullable disable

namespace Pharmacy1.Models
{
    public partial class Firm
    {
        public Firm()
        {
            Medicines = new HashSet<Medicine>();
        }

        public int FirmId { get; set; }
        public string FirmName { get; set; }

        public virtual ICollection<Medicine> Medicines { get; set; }
    }
}
