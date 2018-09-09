using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Commerce.Core.Catalog.Api;
using Commerce.Core.Catalog.Api.Dto;
using Commerce.Core.Catalog.Api.Models;
using Commerce.Core.Orders.Api.Dto;
using Commerce.Core.Orders.Api.Models;

namespace Commerce.Core.Shop.Api
{
    public interface IShop
    {
        Guid Id { get; }
        Task<IEnumerable<GetProductDto>> GetAllProductsAsync();
        Task CreateOrder(CreateOrderDto order);
        Task<GetOrderDto> GetOrderAsync(Guid id);
        Task<GetOrderDto> GetOrderAsync(string id);
        decimal CalculateOrderRevenue(GetOrderDto order);
    }
}