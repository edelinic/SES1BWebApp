using System;
using System.Collections.Generic;

namespace SES1B.Models
{
    public partial class OrderItems
    {
        public int Quantity { get; set; }
        public int OrderId { get; set; }
        public int MenuItemId { get; set; }
    }
}
