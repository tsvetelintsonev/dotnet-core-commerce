using System;
using System.Threading.Tasks;
using Commerce.Core.Orders.Api.Models;

namespace Commerce.Core.Orders.Api.Services
{
    public interface IOrdersService
    {
        Task Save(Order order);
         Task<Order> GetById(Guid id);
    }
}