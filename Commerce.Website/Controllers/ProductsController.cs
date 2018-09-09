using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Commerce.Core.Orders.Api.Models;
using Commerce.Core.Shop.Api;
using Commerce.Website.Models;
using Microsoft.AspNetCore.Mvc;
using Mapster;

namespace Commerce.Website.Controllers
{
    [Route("")]
    public class ProductsController : Controller
    {
        private readonly IShop _shop;
        public ProductsController(IShop shop)
        {
            _shop = shop;
        }

        [Route("")]
        public async Task<IActionResult> Index() {
            IEnumerable<ProductViewModel> products = (await _shop.GetAllProductsAsync()).Adapt<IEnumerable<ProductViewModel>>();
            return View(products);
        }
    }
}