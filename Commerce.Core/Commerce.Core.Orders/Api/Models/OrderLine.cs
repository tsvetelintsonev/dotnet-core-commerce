using Commerce.Core.Api.Shop.Models;
using Commerce.Core.Catalog.Api.Models;

namespace Commerce.Core.Orders.Api.Models
{
    public class OrderLine
    {
        public int Quantity { get; set; }
        public Product Product { get; set; }
    }
}