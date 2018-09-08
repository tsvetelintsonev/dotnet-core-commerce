using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Commerce.Core.Api.Repositories
{
    public interface ISimpleRepository<TModel>
    {
        Task CreateAsync(TModel model);
        Task<TModel> GetByIdAsync(string id);

        Task<TModel> GetByIdAsync(Guid id);
        Task DeleteAsync(string id);
        Task DeleteAsync(Guid id);
        Task<IEnumerable<TModel>> GetAllAsync();
    }
}