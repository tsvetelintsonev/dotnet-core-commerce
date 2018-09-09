using System.Collections.Generic;
using Commerce.Core.Catalog.Api.Models;
using MongoDB.Driver;
using Commerce.Core.Api.Repositories.Mongo;

namespace Commerce.Core.Catalog.Api.Repositories.Mongo
{
    public class ProductsRepository : SimpleMongoRepository<Product>, IProductsRepository
    {
        protected override string CollectionName => "Products";

        public ProductsRepository(IMongoDatabase database) : base(database)
        {
        }

    }
}