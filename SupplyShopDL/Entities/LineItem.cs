using System;
using System.Collections.Generic;

#nullable disable

namespace SupplyShopDL.Entities
{
    public partial class LineItem
    {
        public LineItem()
        {
            OrdersNavigation = new HashSet<Order>();
        }

        public int LineItemId { get; set; }
        public int? Quantity { get; set; }
        public int? ProductId { get; set; }
        public int? OrdersId { get; set; }

        public virtual Order Orders { get; set; }
        public virtual Product Product { get; set; }
        public virtual ICollection<Order> OrdersNavigation { get; set; }
    }
}
