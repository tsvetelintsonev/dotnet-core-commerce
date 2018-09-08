using System.Collections.Generic;
using Commerce.Core.Api.Repositories;
using Commerce.Core.Catalog.Api.Models;

namespace Commerce.Core.Catalog.Api.Repositories
{
    public interface IProductsRepository : ISimpleRepository<Product>
    {
    }
}