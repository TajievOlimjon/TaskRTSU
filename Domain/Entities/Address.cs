using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public  class Address
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Введите адрес "),
            MaxLength(100,ErrorMessage = "Число символов должен быть минимум 100")]
        public string Name { get; set; }
        public virtual List<Employee> Employees { get; set; }
        public virtual List<Department> Departments { get; set; }

    }
}
