using System.Collections.Generic;
using Commerce.Core.Api.Models;

namespace Commerce.Core.Orders.Api.Models
{
    public class Order : ModelWithId
    {
        IEnumerable<OrderLine> OrderLines {get; set;}
    }
}