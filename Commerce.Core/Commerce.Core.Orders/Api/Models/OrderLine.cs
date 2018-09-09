using System;
using Commerce.Core.Api.Shop.Models;
using Commerce.Core.Catalog.Api.Models;

namespace Commerce.Core.Orders.Api.Models
{
    public class OrderLine
    {
        public int Quantity { get; set; }
        public Guid ProductId { get; set; }
    }
}