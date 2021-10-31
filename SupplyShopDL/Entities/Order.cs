using System;
using System.Collections.Generic;

#nullable disable

namespace SupplyShopDL.Entities
{
    public partial class Order
    {
        public Order()
        {
            LineItemOrderJoins = new HashSet<LineItemOrderJoin>();
        }

        public int OrdersId { get; set; }
        public string ItemName { get; set; }
        public int StoreId { get; set; }
        public double TotalPrice { get; set; }
        public int LineItemId { get; set; }
        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual LineItem LineItem { get; set; }
        public virtual Storefront Store { get; set; }
        public virtual ICollection<LineItemOrderJoin> LineItemOrderJoins { get; set; }
    }
}
