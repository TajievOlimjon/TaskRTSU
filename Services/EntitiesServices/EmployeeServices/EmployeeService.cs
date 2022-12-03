using AutoMapper;
using Domain.Entities;
using Domain.EntitiesDto;
using Domain.EntitiesDto.EmployeeDTOs;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Persistence.Data;

namespace Services.EntitiesServices.EmployeeServices
{   
    public class EmployeeService:IEmployeeService
    {  
        private readonly ApplicationContext _context;
        private readonly ILogger<EmployeeService> _logger;
        private readonly IMapper _mapper;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public EmployeeService(ApplicationContext context, 
            ILogger<EmployeeService> logger,IMapper mapper, IWebHostEnvironment web)
        {
            _context = context;
            _logger = logger;
            _mapper = mapper;
            _webHostEnvironment = web;
        }

        public async ValueTask<int> DeleteByIdAsync(int id)
        {   
            var employee =
                await _context.Employees.FindAsync(id);
            if (employee != null)
            {
                _context.Employees.Remove(employee);

                var x = await _context.SaveChangesAsync();
            }
            return 0;
        }

        public async ValueTask<List<EmployeeDto>> GetAllAsync()
        {
            var employees = 
                await _context.Employees.Include(x=>x.Department).ToListAsync();

            var mapped = _mapper.Map<List<EmployeeDto>>(employees);
            return mapped;
        }
        public async ValueTask<List<Employee>> GetEmployees()
        {
            var employees =
                await _context.Employees.Include(x => x.Department).ToListAsync();


            return employees;
        }

        public async ValueTask<EmployeeDto> GetByIdAsync(int Id)
        {
            var employee =
                await _context.Employees.FindAsync(Id);

            var mapped = _mapper.Map<EmployeeDto>(employee);

            return mapped;

        }

        public async ValueTask<EmployeeDto> GetByNameAsync(string name)
        {
            var employee = await _context.Employees
                .FirstOrDefaultAsync(x=>x.Equals(name));

            var mapped = _mapper.Map<EmployeeDto>(employee);

            return mapped;
        }

        public async ValueTask<int> InsertAsync(EmployeeDto entity)
        {
            var mapped = _mapper.Map<Employee>(entity);

                mapped.Image = InsertFile(entity);

            await _context.Employees.AddAsync(mapped);

            var x = await _context.SaveChangesAsync();

            return x;
        }

        

        public async ValueTask<int> UpdateAsync(EmployeeDto entity)
        {
            var mapped = _mapper.Map<Employee>(entity);

             mapped.Image = UpdateFile(entity);

            _context.Attach(mapped);
            _context.Entry(mapped).State = EntityState.Modified;

            var s = await _context.SaveChangesAsync();

            return s;                
                
        }
        public string InsertFile(EmployeeDto employeeImage)
        {
            var fileName =
                Path.GetFileName(employeeImage.Image.FileName);

            var path = 
                Path.Combine(_webHostEnvironment.WebRootPath, "Images", fileName);

            using (var stream = new FileStream(path, FileMode.Create))
            {
                employeeImage.Image.CopyTo(stream);
            }
            return fileName;
        }
        public  string UpdateFile(EmployeeDto dto)
        {
            var fileName =
                Guid.NewGuid() + "_" + Path.GetFileName(dto.Image.FileName);

            var path = 
                Path.Combine(_webHostEnvironment.WebRootPath, "Images", fileName);

            using (var stream = new FileStream(path, FileMode.Create))
            {
                dto.Image.CopyTo(stream);
            }
            return fileName;
        }

        public async ValueTask<GetEmployeeDto> GetEmployeeById(int id)
        {
            var employee = await _context.Employees.FindAsync(id);
            var mapped = _mapper.Map<GetEmployeeDto>(employee);
            return mapped;
        }
    }
}
