using System;
using Commerce.Core.Catalog.Api;

namespace Commerce.Core.Shop.Api
{
    public interface IShop
    {
        Guid Id { get; }
        IProductCatalog ProductCatalog { get; }
    }
}