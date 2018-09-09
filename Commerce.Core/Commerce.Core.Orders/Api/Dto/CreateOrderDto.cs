using System;
using System.Collections.Generic;
using Commerce.Core.Api.Models;

namespace Commerce.Core.Orders.Api.Dto
{
    public class CreateOrderDto : ModelWithId
    {
        public CreateOrderDto() {
            Id = Guid.NewGuid();
        }

        public Guid ShopId { get; set; }
        public IEnumerable<CreateOrderLineDto> OrderLines {get; set;}
    }
}