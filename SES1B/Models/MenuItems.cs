using System;
using System.Collections.Generic;

namespace SES1B.Models
{
    public partial class MenuItems
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public sbyte? Availability { get; set; }
    }
}
