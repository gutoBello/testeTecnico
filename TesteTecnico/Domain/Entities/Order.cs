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
        public float Price { get; private set; }
        public DateTime CreatedAt { get; private set; }

        public Order(float price)
        {
            ValidateDomain(price);
        }

        public Order(int id, float price)
        {
            DomainExceptionValidation.When(id <= 0, "Invalid Id");
            Id = id;
            ValidateDomain(price);
        }

        public void Update(float price)
        {
            ValidateDomain(price);
        }

        private void ValidateDomain(float price)
        {
            DomainExceptionValidation.When(price <= 0, "Invalid price. Must be greater than 0");

            Price = price;
        }
    }
}
