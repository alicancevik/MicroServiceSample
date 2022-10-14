using MicroServiceEntities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CategoryApiSample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        List<Category> categories = new List<Category>()
        {
            new Category{ Id = 1, Name = "Category1" },
            new Category{ Id = 2, Name = "Category2" },
            new Category{ Id = 3, Name = "Category3" },
            new Category{ Id = 4, Name = "Category4" },
            new Category{ Id = 5, Name = "Category5" },

        };

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(categories);
        }

        [HttpGet("{categoryId}")]
        public IActionResult GetById(int categoryId)
        {
            var category = categories.Where(x => x.Id == categoryId);

            return Ok(category);
        }
    }
}
