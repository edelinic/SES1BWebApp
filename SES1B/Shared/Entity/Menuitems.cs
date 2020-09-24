using System;
using System.Collections.Generic;

namespace SES1BBackendAPI.Domain.Entity
{
    public partial class Menuitems
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public byte Lunch { get; set; }
        public byte Dinner { get; set; }
    }
}
