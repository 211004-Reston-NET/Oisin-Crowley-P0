using System;
using System.Collections.Generic;

#nullable disable

namespace SupplyShopDL.Entities
{
    public partial class LineItemOrderJoin
    {
        public int LioId { get; set; }
        public int LineItemId { get; set; }
        public int OrdersId { get; set; }

        public virtual LineItem LineItem { get; set; }
        public virtual Order Orders { get; set; }
    }
}
