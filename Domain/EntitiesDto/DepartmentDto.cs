using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.EntitiesDto
{
    public class DepartmentDto
    {
        public int Id { get; set; }
        public string DepartmentName { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
    }
}
