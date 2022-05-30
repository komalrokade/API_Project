using System;
using System.Collections.Generic;

#nullable disable

namespace CS_EntityFramework.Models
{
    public partial class Costomer
    {
        public Costomer()
        {
            Orders = new HashSet<Order>();
        }

        public int CustNo { get; set; }
        public string CustName { get; set; }
        public string CustEmail { get; set; }
        public string CustAddress { get; set; }
        public string CustCity { get; set; }
        public string CustState { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
