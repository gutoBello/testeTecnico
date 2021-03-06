using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TT.Infra.Domain.Entities;

namespace TesteTecnico.Application.DTOs
{
    public class CreateOrderDTO
    {
        public int Id { get; set; }
        [Range(1, 999999)]
        public decimal Price { get; set; }
        [Range(1, int.MaxValue)]
        public int CustomerId { get; set; }
    }
}
