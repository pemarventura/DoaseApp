using DoaseApp.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoaseApp.Shared
{
    public class Person
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set;}
        public string? City { get; set; }
        public string? Neighborhood { get; set; }
        public string? Address { get; set; }
        public string? CEP { get; set; }
        public BrazilianState State { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.Now;

    }
}
