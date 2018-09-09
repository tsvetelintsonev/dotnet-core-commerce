using System;
using Commerce.Core.Api.Shop.Models;

namespace Commerce.Website.Models
{
    public class ProductViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Money Price { get; set; }
    }
}