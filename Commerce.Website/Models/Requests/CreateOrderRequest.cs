using System;
using System.Collections.Generic;

namespace Commerce.Website.Models.Requests
{
    public class CreateOrderRequest
    {
        public IEnumerable<CreateOrderLineRequest> OrderLines { get; set; }
    }

    public class CreateOrderLineRequest {
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
    }
}