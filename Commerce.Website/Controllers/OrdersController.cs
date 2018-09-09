using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Commerce.Core.Shop.Api;
using Microsoft.AspNetCore.Mvc;
using Commerce.Website.Models.Requests;
using Commerce.Core.Orders.Api.Dto;
using System;
using Commerce.Website.Models;
using Mapster;

namespace Commerce.Website.Controllers
{   
    [Route("orders")]
    public class OrdersController : Controller
    {
        private readonly IShop _shop;
        public OrdersController(IShop shop)
        {
            _shop = shop;
        }

        [Route("")]
        [HttpGet]
        public async Task<IActionResult> Index() {
            return View();
        }

        [HttpPost("")]
        public async Task<IActionResult> CreateOrder([FromBody] CreateOrderRequest orderRequest) {
            CreateOrderDto newOrder = new CreateOrderDto();
            newOrder.ShopId = _shop.Id;
            List<CreateOrderLineDto> newOrderLines = new List<CreateOrderLineDto>();
            foreach(CreateOrderLineRequest orderLineRequest in orderRequest.OrderLines) {
                newOrderLines.Add(
                    new CreateOrderLineDto {
                        ProductId = orderLineRequest.ProductId,
                        Quantity = orderLineRequest.Quantity
                    }
                );
            }
            newOrder.OrderLines = newOrderLines;
            await _shop.CreateOrder(newOrder);

            return Ok(newOrder.Id);
        }

        [Route("receipt/{orderId}")]
        public async Task<IActionResult> Receipt(string orderId) {
            GetOrderDto order = await _shop.GetOrderAsync(new Guid(orderId));
            OrderViewModel orderViewModel = order.Adapt<OrderViewModel>();
            orderViewModel.Revenue = _shop.CalculateOrderRevenue(order);

            return View("Receipt", orderViewModel);
        }
    }
}