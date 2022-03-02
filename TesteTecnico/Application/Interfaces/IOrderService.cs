using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteTecnico.Application.DTOs;
using TT.Infra.Domain.Entities;

namespace TesteTecnico.Application.Interfaces
{
    public interface IOrderService
    {
        OrderDTO Create(OrderDTO order);

        Task<OrderDTO> GetByIdAsync(int id);
    }
}
