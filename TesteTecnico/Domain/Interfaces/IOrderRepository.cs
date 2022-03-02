using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TT.Infra.Domain.Entities;

namespace TT.Infra.Domain.Interfaces
{
    public interface IOrderRepository
    {
        Order Create(Order order);

        Task<Order> GetById(int id);
    }
}
