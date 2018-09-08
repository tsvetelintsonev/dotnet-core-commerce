using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Commerce.Core.Api.Shop.Models;
using Commerce.Core.Catalog.Api.Models;
using Commerce.Core.Catalog.Api.Repositories;

namespace Commerce.Core.Catalog.Api.Services
{
    public class ProductsService : IProductsService
    {
        private readonly IProductsRepository _producsRepository;

        public ProductsService(IProductsRepository producsRepository)
        {
            _producsRepository = producsRepository;
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await Task.FromResult(new List<Product> {
                {new Product { 
                    Id = new Guid("dc0bb6fa-22d2-4423-b03b-41834bedd662"),
                    Name = "Apple juice",
                    Price = new Money{ Amount = 12.5M, Currency = "DNK"},
                }},
                {new Product { 
                    Id = new Guid("62af99ac-a948-4c7b-8dae-fedd9aad97c4"),
                    Name = "Bread",
                    Price = new Money{ Amount = 5M, Currency = "DNK"},
                }}
            });
            
            // return await _producsRepository.GetAllAsync();
        }
    }
}