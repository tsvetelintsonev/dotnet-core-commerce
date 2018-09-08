using Commerce.Core.Api.Repositories;
using Commerce.Core.Catalog.Api;
using Commerce.Core.Catalog.Api.Repositories;
using Commerce.Core.Catalog.Api.Repositories.Mongo;
using Commerce.Core.Catalog.Api.Services;
using Commerce.Core.Orders.Api.Models;
using Commerce.Core.Orders.Api.Repositories;
using Commerce.Core.Orders.Api.Repositories.Mongo;
using Commerce.Core.Orders.Api.Services;
using Commerce.Core.Shop.Api;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Driver;
using SuhMapi.Core.Api.Repositories.Mongo;

namespace Commerce.Core.Shop.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static void AddCommerce(this IServiceCollection services) {
            // Repositories
            services
                .AddTransient<IOrdersRepository, OrdersRepository>()
                .AddTransient<IProductsRepository, ProductsRepository>()
                .AddTransient<IProductCatalog, ProductCatalog>();

            // Services
            services.AddTransient<IOrdersService, OrdersService>();
            services.AddTransient<IProductsService, ProductsService>();

            // The Shop 
            services.AddScoped<IShop, Api.Shop>();
        }
    }
}