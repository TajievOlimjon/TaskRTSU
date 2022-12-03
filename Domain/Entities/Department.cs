using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public  class Department
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Введите названия отделла ?"),
            MaxLength(85,ErrorMessage = "Число символов должен быть минимум 85")]
        public string DepartmentName { get; set; }
        public string Description { get; set; }

        [Required(ErrorMessage ="Введите адрес ")]
        public string Address { get; set; }
        public virtual List<Employee> Employees { get; set; }
    }
}
