using System.Collections.Generic;
using System.Threading.Tasks;
using Commerce.Core.Catalog.Api.Models;
using Commerce.Core.Catalog.Api.Services;

namespace Commerce.Core.Catalog.Api
{
    public class ProductCatalog : IProductCatalog
    {

        private readonly IProductsService _productService;

        public ProductCatalog(IProductsService productService) {
            _productService = productService;
        }

        public async Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            return await _productService.GetAllAsync();
        }
    }
}