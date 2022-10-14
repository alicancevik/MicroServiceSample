using MicroServiceEntities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerApiSample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        List<Customer> customers = new List<Customer>()
        {
            new Customer{ Id = 1, Name = "Customer1", TelephoneNumber = "1122222222" },
            new Customer{ Id = 2, Name = "Customer2", TelephoneNumber = "2122222222" },
            new Customer{ Id = 3, Name = "Customer3", TelephoneNumber = "3122222222" },
            new Customer{ Id = 4, Name = "Customer4", TelephoneNumber = "4122222222" },
            new Customer{ Id = 5, Name = "Customer5", TelephoneNumber = "5122222222" },
            
        };

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(customers);
        }

        [HttpGet("{customerId}")]
        public IActionResult GetById(int customerId)
        {
            var customer = customers.Where(x=> x.Id == customerId);

            return Ok(customer);
        }
    }
}
