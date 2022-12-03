using AutoMapper;
using Domain.EntitiesDto.PerformerDTOs;
using Microsoft.EntityFrameworkCore;
using Persistence.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.EntitiesServices.PerformerServices
{
    public class PerformerService : IPerformerService
    {
        private readonly ApplicationContext _context;
        private readonly IMapper _mapper;
        public PerformerService(ApplicationContext context,IMapper mapper)
        {
            _context=context;
            _mapper = mapper;
        }
        public async ValueTask<int> DeleteByIdAsync(int id)
        {
            var performer = 
                await _context.Employees.FindAsync(id);

            if (performer == null) return 0;

            _context.Employees.Remove(performer);

            var x = await _context.SaveChangesAsync();
            return x;
        }

        public async ValueTask<List<PerformerDto>> GetAllAsync()
        {
            var performers = 
                await _context.Performers.ToListAsync();

            var mapped = _mapper.Map<List<PerformerDto>>(performers);

            return mapped;
        }

        public ValueTask<PerformerDto> GetByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public ValueTask<PerformerDto> GetByNameAsync(string name)
        {
            throw new NotImplementedException();
        }

        public ValueTask<int> InsertAsync(PerformerDto entity)
        {
            throw new NotImplementedException();
        }

        public ValueTask<int> UpdateAsync(PerformerDto entity)
        {
            throw new NotImplementedException();
        }
    }
}
