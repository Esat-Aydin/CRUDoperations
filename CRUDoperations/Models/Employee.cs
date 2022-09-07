using System;
using System.ComponentModel.DataAnnotations;

namespace CRUDoperations.Models
{
    public class Employee
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Name cannot exceed 50 characters long")]

        public string Name { get; set; }
    }
}
