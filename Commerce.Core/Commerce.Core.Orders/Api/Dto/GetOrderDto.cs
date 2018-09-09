using System;
using System.Collections.Generic;
using Commerce.Core.Api.Models;

namespace Commerce.Core.Orders.Api.Dto
{
    public class GetOrderDto : ModelWithId
    {
        public Guid ShopId { get; set; }
        public IEnumerable<GetOrderLineDto> OrderLines { get; set; }
    }
}