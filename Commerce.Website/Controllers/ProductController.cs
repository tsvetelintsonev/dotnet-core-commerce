using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Commerce.Website.Models;

namespace Commerce.Website.Controllers
{
    [Route("")]
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return Ok("TEst");
        }
    }
}
