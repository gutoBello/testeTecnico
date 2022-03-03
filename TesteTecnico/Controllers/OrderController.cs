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
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpPost]
        public IActionResult AddNewOrder([FromBody] CreateOrderDTO orderDto)
        {
            _orderService.Create(orderDto);
            return CreatedAtAction(nameof(GetOrderById), new { Id = orderDto.Id }, orderDto);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetOrderById(int id)
        {
            OrderDTO order = await _orderService.GetByIdAsync(id);
            if (order != null)
                return Ok(order);
            else
                return NotFound();
        }
    }
}
