using Microsoft.AspNetCore.Mvc;
using BudgetTracker.models;
using BudgetTracker.Context;
using BudgetTracker.Services;
using Microsoft.EntityFrameworkCore;

namespace BudgetTrackerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customer;

        public CustomerController(ICustomerService customer)
        {
            _customer = customer;
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register(Customer user)
        {
            var result = await _customer.CreateCustomer(user);
            if(result == null)
            {
                return BadRequest();
            }
            return Ok(result);
        }


        

        [HttpPost("Login")]
        public async Task<IActionResult> Login(string email, string password)
        {
            var user = await _customer.LogIn(email, password);
            if (user == null)
            {
                return NotFound(user);
            }
            return Ok(user);
        }
    }
}