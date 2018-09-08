using System;
using Commerce.Core.Catalog.Api;
using Commerce.Core.Orders.Api.Services;

namespace Commerce.Core.Shop.Api
{
    public class Shop : IShop
    {
        private Guid _id;
        private IProductCatalog _catalog;

        Shop(IProductCatalog catalog, IOrdersService ordersService) {
            _id = new Guid();

        }

        public Guid Id { get => _id; }
        public IProductCatalog ProductCatalog { get => _catalog; }
    }
}