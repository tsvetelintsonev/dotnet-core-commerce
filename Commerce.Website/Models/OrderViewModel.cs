using System;
using System.Collections.Generic;

namespace Commerce.Website.Models
{
    public class OrderViewModel
    {
        public Guid Id;
        public Guid ShopId { get; set; }
        public IEnumerable<OrderLineViewModel> OrderLines { get; set; }
        public decimal Revenue { get; set; }
    }
}