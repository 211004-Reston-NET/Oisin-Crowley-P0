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
        }

        public int ProductId { get; set; }
        public string ItemName { get; set; }
        public double ItemPrice { get; set; }
        public string ItemDesc { get; set; }
        public string Category { get; set; }
        public int ProdQuantity { get; set; }
        public int StoreId { get; set; }

        public virtual Storefront Store { get; set; }
        public virtual ICollection<LineItem> LineItems { get; set; }
    }
}
