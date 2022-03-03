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
    public class CustomerRepository : ICustomerRepository
    {
        ApplicationDbContext _customerContext;

        public CustomerRepository(ApplicationDbContext context)
        {
            _customerContext = context;
        }

        public Customer Create(Customer customer)
        {
            _customerContext.Add(customer);
            _customerContext.SaveChanges();

            return customer;
        }

        public async Task<IEnumerable<Customer>> GetAllAsync()
        {
            return await _customerContext.Customers.ToListAsync();
        }

        public async Task<Customer> GetByIdAsync(int id)
        {
            return await _customerContext.Customers.Include(c => c.Orders).FirstOrDefaultAsync(c => c.Id == id);
        }
    }
}
