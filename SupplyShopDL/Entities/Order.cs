using System;
using System.Collections.Generic;

#nullable disable

namespace SupplyShopDL.Entities
{
    public partial class Order
    {
        public Order()
        {
            Customers = new HashSet<Customer>();
            LineItems = new HashSet<LineItem>();
            Storefronts = new HashSet<Storefront>();
        }

        public int OrdersId { get; set; }
        public string ItemName { get; set; }
        public int? StoreId { get; set; }
        public double? TotalPrice { get; set; }
        public int? LineItemId { get; set; }

        public virtual LineItem LineItem { get; set; }
        public virtual Storefront Store { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<LineItem> LineItems { get; set; }
        public virtual ICollection<Storefront> Storefronts { get; set; }
    }
}
