using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TT.Infra.Domain.Entities;

namespace TT.Infra.Domain.Interfaces
{
    public interface ICustomerRepository
    {
        Customer Create(Customer customer);
        Task<IEnumerable<Customer>> GetAllAsync();
        Task<Customer> GetByIdAsync(int id);
    }
}
