using System;
using System.Collections.Generic;

#nullable disable

namespace SupplyShopDL.Entities
{
    public partial class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustStreetAdd { get; set; }
        public string CustCity { get; set; }
        public string CustState { get; set; }
        public int? CustZip { get; set; }
        public string CustEmail { get; set; }
        public string CustPhone { get; set; }
        public int? OrdersId { get; set; }

        public virtual Order Orders { get; set; }
    }
}
