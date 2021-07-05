using System;
using System.Collections.Generic;

#nullable disable

namespace Pharmacy1.Models
{
    public partial class Medicine
    {
        public Medicine()
        {
            MedicineToTags = new HashSet<MedicineToTag>();
            OrderItemToMedicines = new HashSet<OrderItemToMedicine>();
        }

        public int MedicineId { get; set; }
        public string MedicineName { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public DateTime PublishDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsReceipt { get; set; }
        public int? FirmId { get; set; }
        public string Barcode { get; set; }

        public virtual Firm Firm { get; set; }
        public virtual ICollection<MedicineToTag> MedicineToTags { get; set; }
        public virtual ICollection<OrderItemToMedicine> OrderItemToMedicines { get; set; }
    }
}
