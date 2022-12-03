using AutoMapper;
using Domain.Entities;
using Domain.EntitiesDto;
using Domain.EntitiesDto.EmployeeDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.MapperServices
{
    public class MapService:Profile
    {
        public MapService()
        {
            CreateMap<DepartmentDto, Department>().ReverseMap();
            CreateMap<EmployeeDto, Employee>().ReverseMap();
            CreateMap<GetEmployeeDto, Employee>().ReverseMap();
        }
    }
}
