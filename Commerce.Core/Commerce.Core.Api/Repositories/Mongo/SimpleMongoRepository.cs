using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Commerce.Core.Api.Repositories;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Commerce.Core.Api.Repositories.Mongo 
{

    public abstract class SimpleMongoRepository<TModel>: ISimpleRepository<TModel> 
    {
        private IMongoDatabase _database;
        public IMongoDatabase Database { get => _database; private set{} }
        protected abstract string CollectionName { get; }

        public SimpleMongoRepository(IMongoDatabase database) {
            _database = database;
        }

        public async Task CreateAsync(TModel model)
        {
            await _database.GetCollection<TModel>(CollectionName).InsertOneAsync(model);
        }

        public async Task<TModel> GetByIdAsync(string id)
        {
            return await _database.GetCollection<TModel>(CollectionName).Find(
                Builders<TModel>.Filter.Eq("_id", new Guid(id))
            ).SingleAsync();
        }

        public async Task<TModel> GetByIdAsync(Guid id)
        {
            return await _database.GetCollection<TModel>(CollectionName).Find(
                Builders<TModel>.Filter.Eq("_id", id)
            ).SingleAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            await _database.GetCollection<TModel>(CollectionName).DeleteOneAsync(
                Builders<TModel>.Filter.Eq("Id", id)
            );
        }

        public async Task<IEnumerable<TModel>> GetAllAsync()
        {
            return await _database.GetCollection<TModel>(CollectionName).Find(FilterDefinition<TModel>.Empty).ToListAsync();
        }
    }

}