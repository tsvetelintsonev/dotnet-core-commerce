using System;
using System.Collections.Generic;
using Commerce.Core.Api.Models;

namespace Commerce.Core.Orders.Api.Models
{
    public class Order : ModelWithId
    {
        public Guid ShopId { get; set; }
        public IEnumerable<OrderLine> OrderLines {get; set;}
    }
}