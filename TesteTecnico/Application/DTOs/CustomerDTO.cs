using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TesteTecnico.Application.DTOs
{
    public class CustomerDTO
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "The name is required")]
        [MinLength(3, ErrorMessage = "Minimum 3 characteres")]
        [MaxLength(100, ErrorMessage = "Maximum 100 characteres")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The email is required")]
        [MinLength(3, ErrorMessage = "Minimum 10 characteres")]
        [MaxLength(100, ErrorMessage = "Maximum 70 characteres")]
        public string Email { get; set; }
    }
}
