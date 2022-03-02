using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteTecnico.Application.DTOs;

namespace TesteTecnico.Application.Interfaces
{
    public interface ICustomerService
    {
        CustomerDTO Create(CustomerDTO customer);
        Task<IEnumerable<CustomerDTO>> GetAllAsync();
        Task<CustomerDTO> GetByIdAsync(int id);
    }
}
