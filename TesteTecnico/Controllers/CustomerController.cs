using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TesteTecnico.Application.DTOs;
using TesteTecnico.Application.Interfaces;

namespace TesteTecnico.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpPost]
        public IActionResult AddNewCustomer([FromBody] CustomerDTO customerDto)
        {
            _customerService.Create(customerDto);
            return CreatedAtAction(nameof(GetCustomerById), new { Id = customerDto.Id }, customerDto);
        }

        [HttpGet]
        public async Task<IEnumerable<CustomerDTO>> GetAllCustomers()
        {
            return await _customerService.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCustomerById(int id)
        {
            CustomerWithOrdersDTO customer = await _customerService.GetByIdAsync(id);
            if (customer != null)
                return Ok(customer);
            else
                return NotFound();
        }
    }
}
