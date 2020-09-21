using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RESTapiSoftim.Data;
using RESTapiSoftim.Models;

namespace RESTapiSoftim.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly RESTapiSoftimContext _context;

        public CustomersController(RESTapiSoftimContext context)
        {
            _context = context;
        }

        // GET: Customers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Customers>>> GetCustomer()
        {
            return await _context.Customers.ToListAsync();
        }

        // GET: Customers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Customers>> GetCustomer(int id)
        {
            var customer = await _context.Customers.FindAsync(id);

            if (customer == null)
            {
                return NotFound();
            }

            return customer;
        }

        

        // POST: Customers
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Customers>> PostCustomer(Customers customer)
        {
            if (customer.Age < 0)
            {
                return BadRequest("Customer must be born already (age >= 0)!");
            }

            if (!customer.Sex.Equals("M") && !customer.Sex.Equals("F"))
            {
                return BadRequest("Sex must be F or M!");
            }
            _context.Customers.Add(customer);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCustomer", new { id = customer.Id }, customer);
        }

        
    }
}
