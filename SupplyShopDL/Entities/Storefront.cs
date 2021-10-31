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
            Products = new HashSet<Product>();
        }

        public int StoreId { get; set; }
        public string StoreName { get; set; }
        public string StoreAdd { get; set; }
        public string StoreCity { get; set; }
        public string StoreState { get; set; }
        public int StoreZip { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
