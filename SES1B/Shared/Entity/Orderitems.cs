using System;
using System.Collections.Generic;

namespace SES1BBackendAPI.Domain.Entity
{
    public partial class Orderitems
    {
        public int Quantity { get; set; }
        public int OrderId { get; set; }
        public int MenuItemId { get; set; }

        public virtual Menuitems MenuItem { get; set; }
        public virtual Order Order { get; set; }
    }
}
