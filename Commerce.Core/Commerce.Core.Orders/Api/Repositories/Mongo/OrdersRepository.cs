using Commerce.Core.Orders.Api.Models;
using MongoDB.Driver;
using Commerce.Core.Api.Repositories.Mongo;

namespace Commerce.Core.Orders.Api.Repositories.Mongo
{
    public class OrdersRepository : SimpleMongoRepository<Order>, IOrdersRepository
    {
        protected override string CollectionName => "Orders";

        public OrdersRepository(IMongoDatabase database) : base(database)
        {
        }

    }
}