using Domain.Enums;
using Microsoft.AspNetCore.Http;

namespace Domain.EntitiesDto
{
    public  class EmployeeDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Middle { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTimeOffset BitrthDate { get; set; } = DateTimeOffset.UtcNow;
        public Gender Gender { get; set; }
        public IFormFile? Image { get; set; }
        public string Address { get; set; }
        public int DepartmentId { get; set; }
        public string Position { get; set; }
    }
}
