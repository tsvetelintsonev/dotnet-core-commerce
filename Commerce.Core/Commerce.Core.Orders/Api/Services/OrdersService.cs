using System;
using System.Threading.Tasks;
using Commerce.Core.Orders.Api.Models;
using Commerce.Core.Orders.Api.Repositories;

namespace Commerce.Core.Orders.Api.Services
{
    public class OrdersService : IOrdersService
    {
        private readonly IOrdersRepository _ordersRepository;

        public OrdersService(IOrdersRepository ordersRepository) {
            _ordersRepository = ordersRepository;
        }

        public async Task Save(Order order)
        {
            await _ordersRepository.CreateAsync(order);
        }

        public async Task<Order> GetById(Guid id)
        {
            return await _ordersRepository.GetByIdAsync(id);
        }

    }
}