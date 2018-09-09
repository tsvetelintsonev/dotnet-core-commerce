using System;

namespace Commerce.Core.Orders.Api.Dto
{
    public class CreateOrderLineDto
    {
        public int Quantity { get; set; }
        public Guid ProductId { get; set; }
    }
}