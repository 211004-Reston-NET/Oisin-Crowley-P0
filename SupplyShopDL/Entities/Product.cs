using System;
using System.Collections.Generic;

#nullable disable

namespace SupplyShopDL.Entities
{
    public partial class Product
    {
        public Product()
        {
            LineItems = new HashSet<LineItem>();
            Storefronts = new HashSet<Storefront>();
        }

        public int ProductId { get; set; }
        public string ItemName { get; set; }
        public double? ItemPrice { get; set; }
        public string ItemDesc { get; set; }
        public string Category { get; set; }

        public virtual ICollection<LineItem> LineItems { get; set; }
        public virtual ICollection<Storefront> Storefronts { get; set; }
    }
}
