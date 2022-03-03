using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteTecnico.Application.DTOs;
using TesteTecnico.Application.Interfaces;
using TT.Infra.Domain.Entities;
using TT.Infra.Domain.Interfaces;

namespace TesteTecnico.Application.Services
{
    public class OrderService : IOrderService
    {
        IOrderRepository _orderRepository;
        IMapper _mapper;
        public OrderService(IOrderRepository orderRepository, IMapper mapper)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
        }

        public CreateOrderDTO Create(CreateOrderDTO order)
        {
            var orderEntity = _mapper.Map<Order>(order);
            _orderRepository.Create(orderEntity);
            return _mapper.Map<CreateOrderDTO>(orderEntity);
        }

        public async Task<OrderDTO> GetByIdAsync(int id)
        {
            var orderEntity = await _orderRepository.GetByIdAsync(id);
            return _mapper.Map<OrderDTO>(orderEntity);
        }
    }
}
