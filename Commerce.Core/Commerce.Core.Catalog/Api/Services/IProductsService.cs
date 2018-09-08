using System.Collections.Generic;
using System.Threading.Tasks;
using Commerce.Core.Catalog.Api.Models;

namespace Commerce.Core.Catalog.Api.Services
{
    public interface IProductsService
    {
         Task<IEnumerable<Product>> GetAllAsync();
    }
}