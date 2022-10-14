using MicroServiceEntities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductApiSample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        List<Product> products = new List<Product>() 
        { 
            new Product { Id = 1, Name = "Product1", Price = 1000 },
            new Product { Id = 2, Name = "Product2", Price = 2000 },
            new Product { Id = 3, Name = "Product3", Price = 3000 },
            new Product { Id = 4, Name = "Product4", Price = 4000 },
            new Product { Id = 5, Name = "Product5", Price = 5000 },
        };

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(products);
        }

        [HttpGet("{productId}")]
        public IActionResult GetById(int productId)
        {
            var product = products.Where(x => x.Id == productId);

            return Ok(product);
        }
    }
}
