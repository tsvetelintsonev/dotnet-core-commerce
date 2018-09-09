using System;
using System.Threading.Tasks;
using Commerce.Core.Orders.Api.Dto;
using Commerce.Core.Orders.Api.Models;
using Commerce.Core.Orders.Api.Repositories;
using Mapster;

namespace Commerce.Core.Orders.Api.Services
{
    public class OrdersService : IOrdersService
    {
        private readonly IOrdersRepository _ordersRepository;

        public OrdersService(IOrdersRepository ordersRepository) {
            _ordersRepository = ordersRepository;
        }

        public async Task SaveAsync(CreateOrderDto order)
        {
            await _ordersRepository.CreateAsync(order.Adapt<Order>());
        }

        public async Task<GetOrderDto> GetByIdAsync(Guid id)
        {
            return (await _ordersRepository.GetByIdAsync(id)).Adapt<GetOrderDto>();
        }

        public async Task<GetOrderDto> GetByIdAsync(string id)
        {
            return (await _ordersRepository.GetByIdAsync(id)).Adapt<GetOrderDto>();
        }

    }
}