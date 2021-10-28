using System;
using System.Collections.Generic;

#nullable disable

namespace SupplyShopDL.Entities
{
    public partial class Storefront
    {
        public Storefront()
        {
            Orders = new HashSet<Order>();
        }

        public int StoreId { get; set; }
        public string StoreName { get; set; }
        public string StoreAdd { get; set; }
        public string StoreCity { get; set; }
        public string StoreState { get; set; }
        public int StoreZip { get; set; }
        public int? ProductId { get; set; }
        public int? OrdersId { get; set; }

        public virtual Order OrdersNavigation { get; set; }
        public virtual Product Product { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
