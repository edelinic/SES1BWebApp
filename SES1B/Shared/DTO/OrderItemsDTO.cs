using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SES1B.Shared.DTO
{
    public class OrderItemsDTO
    {
        public int Quantity { get; set; }
        public int OrderId { get; set; }
        public int MenuItemId { get; set; }

        public List<MenuItemsDTO> MenuItem { get; set; }
        public List<OrderDTO> Order { get; set; }
    }
}
