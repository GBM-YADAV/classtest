using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WEB_API.Controllers.Models;

namespace WEB_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        public List<Product> prodlist { get; set; }

        public ProductController()
        {
            prodlist = new List<Product>()
            {
            new Product(){Id=1,ProductName="Dairy Milk",Price=50},
            new Product(){Id=2,ProductName="Silk",Price=50},
            new Product(){Id=3,ProductName="Kit Kat",Price=50},
            new Product(){Id=1,ProductName="Snikers",Price=50},
            new Product(){Id=1,ProductName="Munch",Price=50},

            };
        }
        public ActionResult Get()
        {
            var data = prodlist;
            return Ok(data);
        }

    }
}
