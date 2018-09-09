using System;
using System.Threading.Tasks;
using Commerce.Core.Orders.Api.Dto;
using Commerce.Core.Orders.Api.Models;

namespace Commerce.Core.Orders.Api.Services
{
    public interface IOrdersService
    {
        Task SaveAsync(CreateOrderDto order);
        Task<GetOrderDto> GetByIdAsync(Guid id);
        Task<GetOrderDto> GetByIdAsync(string id);
    }
}