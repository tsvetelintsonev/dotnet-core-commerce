using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Commerce.Core.Api.Shop.Models;
using Commerce.Core.Catalog.Api.Dto;
using Commerce.Core.Catalog.Api.Repositories;
using Commerce.Core.Catalog.Api.Services;

namespace Commerce.Core.Catalog.Api
{
    public interface IProductsCatalogService
    {
        Task<IEnumerable<GetProductDto>> GetAllProductsAsync();
        Task<GetProductDto> GetByIdAsync(Guid id);
    }
}