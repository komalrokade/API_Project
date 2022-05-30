using System;
using System.Collections.Generic;

#nullable disable

namespace CS_EntityFramework.Models
{
    public partial class Order
    {
        public int OrderNo { get; set; }
        public string OrderItem { get; set; }
        public string OrderDate { get; set; }
        public int OrderQuantity { get; set; }
        public int CustNo { get; set; }

        public virtual Costomer CustNoNavigation { get; set; }
    }
}
