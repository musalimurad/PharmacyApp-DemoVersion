using System;
using System.Collections.Generic;

#nullable disable

namespace Pharmacy1.Models
{
    public partial class Admin
    {
        public Admin()
        {
            Orders = new HashSet<Order>();
        }

        public int AdminId { get; set; }
        public string Fullname { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public string RePassword { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
