using AutoMapper;
using Domain.Entities;
using Domain.EntitiesDto;
using Microsoft.EntityFrameworkCore;
using Persistence.Data;

namespace Services.EntitiesServices.DepartmentServices
{
    public class DepartmentService : IDepartmentService
    {
        private readonly ApplicationContext _context;
        private readonly IMapper _mapper;

        public DepartmentService(ApplicationContext applicationContext,IMapper mapper)
        {
            _context = applicationContext;
            _mapper = mapper;
        }
        public async ValueTask<int> DeleteByIdAsync(int id)
        {
            var department = await _context.Departments.FindAsync(id);

            _context.Departments.Remove(department);
           var save= await _context.SaveChangesAsync();
            return save;
           
         }

        public async ValueTask<DepartmentDto> GetByIdAsync(int id)
        {
            var department = await (from d in _context.Departments
                                    where d.Id == id
                                    select new DepartmentDto
                                    { 
                                        Id=d.Id,
                                        DepartmentName=d.DepartmentName,
                                        Description=d.Description,
                                        Address=d.Address
                                    }).FirstOrDefaultAsync();
            return department;
        }

        public async ValueTask<DepartmentDto> GetByNameAsync(string name)
        {
            var department = await (from d in _context.Departments
                                    where d.DepartmentName == name
                                    select new DepartmentDto
                                    {
                                        Id = d.Id,
                                        DepartmentName = d.DepartmentName,
                                        Description = d.Description,
                                        Address = d.Address
                                    }).FirstOrDefaultAsync();
            return department;
        }

        public async ValueTask<List<DepartmentDto>> GetAllAsync()
        {
            var department = await (from d in _context.Departments
                                    select new DepartmentDto
                                    {
                                        Id = d.Id,
                                        DepartmentName = d.DepartmentName,
                                        Description = d.Description,
                                        Address = d.Address
                                    }).ToListAsync();
            return department;
        }

        public async ValueTask<int> InsertAsync(DepartmentDto entity)
        {
            var department = _mapper.Map<Department>(entity);
            await _context.Departments.AddAsync(department);
            var save = await _context.SaveChangesAsync();
            return save;
        }

        public async ValueTask<int> UpdateAsync(DepartmentDto entity)
        {
            var department = await _context.Departments.FindAsync(entity.Id);

            department.DepartmentName = entity.DepartmentName;
            department.Description = entity.Description;
            department.Address = entity.Address;

            var save = await _context.SaveChangesAsync();
            return save;
        }
    }
}
