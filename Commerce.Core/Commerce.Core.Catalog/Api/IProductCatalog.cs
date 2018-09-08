using System.Collections.Generic;
using System.Threading.Tasks;
using Commerce.Core.Catalog.Api.Models;

namespace Commerce.Core.Catalog.Api
{
    public interface IProductCatalog
    {
         Task<IEnumerable<Product>> GetAllProductsAsync();
    }
}