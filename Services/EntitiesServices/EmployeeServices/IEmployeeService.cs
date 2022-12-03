using Domain.Entities;
using Domain.EntitiesDto;
using Domain.EntitiesDto.EmployeeDTOs;
using Microsoft.AspNetCore.Http;
using Services.EntitiesServices.BaseEntitieServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.EntitiesServices.EmployeeServices
{
    public  interface IEmployeeService:IBaseEntitieService<EmployeeDto>
    {
         string InsertFile(EmployeeDto employeeImage);
         string UpdateFile(EmployeeDto employeeImage);
         ValueTask<List<Employee>> GetEmployees();
         ValueTask<GetEmployeeDto> GetEmployeeById(int id);
        
    }
}
