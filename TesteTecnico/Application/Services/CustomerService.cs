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
    public class CustomerService : ICustomerService
    {
        ICustomerRepository _customerRepository;
        IMapper _mapper;
        public CustomerService(ICustomerRepository customerRepository, IMapper mapper)
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
        }
        public CustomerDTO Create(CustomerDTO customer)
        {
            var customerEntity = _mapper.Map<Customer>(customer);
            _customerRepository.Create(customerEntity);
            return _mapper.Map<CustomerDTO>(customerEntity);
        }

        public async Task<IEnumerable<CustomerDTO>> GetAllAsync()
        {
            var customersEntity = await _customerRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<CustomerDTO>>(customersEntity);
        }

        public async Task<CustomerDTO> GetByIdAsync(int id)
        {
            var customerEntity = await _customerRepository.GetByIdAsync(id);
            return _mapper.Map<CustomerDTO>(customerEntity);
        }
    }
}
