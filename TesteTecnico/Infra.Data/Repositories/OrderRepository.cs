using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteTecnico.Infra.Data.Context;
using TT.Infra.Domain.Entities;
using TT.Infra.Domain.Interfaces;

namespace TesteTecnico.Infra.Data.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        ApplicationDbContext _orderContext;

        public OrderRepository(ApplicationDbContext context)
        {
            _orderContext = context;
        }

        public Order Create(Order order)
        {
            _orderContext.Add(order);
            _orderContext.SaveChanges();

            return order;
        }

        public async Task<Order> GetByIdAsync(int id)
        {
            return await _orderContext.Orders.Include(q => q.Customer).SingleOrDefaultAsync(o => o.Id == id);
        }
    }
}
