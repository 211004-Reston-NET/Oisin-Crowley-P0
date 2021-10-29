using System;
using System.Collections.Generic;

#nullable disable

namespace SupplyShopDL.Entities
{
    public partial class LineItem
    {
        public LineItem()
        {
            LineItemOrderJoins = new HashSet<LineItemOrderJoin>();
            Orders = new HashSet<Order>();
        }

        public int LineItemId { get; set; }
        public int Quantity { get; set; }
        public int ProductId { get; set; }

        public virtual Product Product { get; set; }
        public virtual ICollection<LineItemOrderJoin> LineItemOrderJoins { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
