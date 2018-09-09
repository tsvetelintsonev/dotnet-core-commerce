using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Commerce.Core.Catalog.Api;
using Commerce.Core.Catalog.Api.Dto;
using Commerce.Core.Catalog.Api.Models;
using Commerce.Core.Orders.Api.Dto;
using Commerce.Core.Orders.Api.Models;
using Commerce.Core.Orders.Api.Services;
using Mapster;

namespace Commerce.Core.Shop.Api
{
    public class Shop : IShop
    {
        private Guid _id;
        private readonly IProductsCatalogService _productsCatalogService;
        private readonly IOrdersService _ordersService;

        public Shop(IProductsCatalogService productsCatalogService, IOrdersService ordersService)
        {
            _id = Guid.NewGuid();
            _productsCatalogService = productsCatalogService;
            _ordersService = ordersService;
        }

        public Guid Id { get => _id; }
        public async Task<IEnumerable<GetProductDto>> GetAllProductsAsync()
        {
            return (await _productsCatalogService.GetAllProductsAsync()).Adapt<IEnumerable<GetProductDto>>();
        }

        public async Task CreateOrder(CreateOrderDto order)
        {
            await _ordersService.SaveAsync(order);
        }

        public async Task<GetOrderDto> GetOrderAsync(Guid id)
        {
            return await GetOrderByIdAsync(id);
        }

        public async Task<GetOrderDto> GetOrderAsync(string id)
        {
            return await GetOrderByIdAsync(new Guid(id));
        }

        private async Task<GetOrderDto> GetOrderByIdAsync(Guid id)
        {
            GetOrderDto order = await _ordersService.GetByIdAsync(id);
            order.OrderLines = order.OrderLines.ToList();
            foreach(var orderLine in order.OrderLines) {
                orderLine.Product = (await GetAllProductsAsync()).FirstOrDefault(x => x.Id == orderLine.ProductId);
            }

            return order;
        }

        public decimal CalculateOrderRevenue(GetOrderDto order)
        {
            return order.OrderLines.Select(x => x.Quantity * x.Product.Price.Amount).Sum(x => x) * 0.1M;
        }
    }
}