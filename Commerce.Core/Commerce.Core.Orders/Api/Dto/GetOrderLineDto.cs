using System;
using Commerce.Core.Catalog.Api.Dto;

namespace Commerce.Core.Orders.Api.Dto
{
    public class GetOrderLineDto
    {
        public Guid ProductId { get; set; }
        public GetProductDto Product { get; set; }
        public int Quantity { get; set; }
    }
}