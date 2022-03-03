using System;
using System.Collections.Generic;
using System.Text;
using TT.Infra.Domain.Validation;

namespace TT.Infra.Domain.Entities
{
    public sealed class Order : Entity
    {
        public Customer Customer { get; private set; }
        public int CustomerId { get; private set; }
        public decimal Price { get; private set; }
        public DateTime CreatedAt { get; private set; }

        public Order(decimal price, int customerId)
        {
            ValidateDomain(price, customerId);
            CreatedAt = DateTime.Now;
        }

        public Order(int id, decimal price, int customerId)
        {
            Id = id;
            ValidateDomain(price, customerId);
            CreatedAt = DateTime.Now;
        }


        private void ValidateDomain(decimal price, int customerId)
        {
            DomainExceptionValidation.When(price <= 0, "Invalid price. Must be greater than 0");
            DomainExceptionValidation.When(customerId <= 0, "Invalid customer.");

            Price = price;
            CustomerId = customerId;
        }
    }
}
