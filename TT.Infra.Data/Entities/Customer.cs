using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using TT.Infra.Domain.Validation;

namespace TT.Infra.Domain.Entities
{
    public sealed class Customer : Entity
    {

        [Required]
        public string Name { get; private set; }
        [Required]
        public string Email { get; private set; }
        public ICollection<Order> Orders { get; set; }

        public Customer(string name, string email)
        {
            ValidateDomain(name, email);
        }

        public Customer(int id, string name, string email)
        {
            Id = id;
            DomainExceptionValidation.When(id <= 0, "Invalid Id");
            ValidateDomain(name, email);
        }

        public void Update(string name, string email)
        {
            ValidateDomain(name, email);
        }

        private void ValidateDomain(string name, string email)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name), "Invalid name. Name is required");
            DomainExceptionValidation.When(name.Length < 3, "Invalid name. Minimum 3 charecters");

            Name = name;

            DomainExceptionValidation.When(string.IsNullOrEmpty(email), "Invalid email. Email is required");
            DomainExceptionValidation.When(email.Length < 10, "Invalid email. Minimum 10 charecters");
            DomainExceptionValidation.When(Util.Validator.EmailValidator(email), "Invalid email.");

            Email = email;
        }
    }
}
