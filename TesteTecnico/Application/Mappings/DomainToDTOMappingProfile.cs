using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteTecnico.Application.DTOs;
using TT.Infra.Domain.Entities;

namespace TesteTecnico.Application.Mappings
{
    public class DomainToDTOMappingProfile : Profile
    {
        public DomainToDTOMappingProfile()
        {
            CreateMap<Customer, CustomerDTO>().IgnoreAllSourcePropertiesWithAnInaccessibleSetter().ReverseMap();
            CreateMap<Customer, CustomerWithOrdersDTO>().ReverseMap();
            CreateMap<Order, OrderDTO>().ReverseMap();
            CreateMap<Order, CreateOrderDTO>().ReverseMap();
        }
    }
}
