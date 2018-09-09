using Commerce.Core.Api.Models;
using Commerce.Core.Api.Shop.Models;

namespace Commerce.Core.Catalog.Api.Dto
{
    public class GetProductDto : ModelWithId
    {
        public string Name { get; set; }
        public Money Price { get; set; }
    }
}