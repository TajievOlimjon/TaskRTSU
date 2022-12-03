using AutoMapper;
using Domain.Entities;
using Domain.EntitiesDto;
using Microsoft.EntityFrameworkCore;
using Persistence.Data;

namespace Services.EntitiesServices.DocumentServices
{
    public class DocumentService : IDocumentService
    {
        private readonly ApplicationContext _context;
        private readonly IMapper _mapper;

        public DocumentService(ApplicationContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async ValueTask<int> DeleteByIdAsync(int id)
        {
            var doc = 
                await _context.Documents.FindAsync(id);

            _context.Documents.Remove(doc);

            return await _context.SaveChangesAsync();
        }

        public async ValueTask<List<DocumentDto>> GetAllAsync()
        {
            var documents = 
                await _context.Documents.ToListAsync();

            var mapped = 
                _mapper.Map<List<DocumentDto>>(documents);

            return mapped;
        }

        public async ValueTask<DocumentDto> GetByIdAsync(int id)
        {
            var doc = await _context.Documents.FindAsync(id);
            var mapped = _mapper.Map<DocumentDto>(doc);
            return mapped;
        }

        public async ValueTask<DocumentDto> GetByNameAsync(string name)
        {
            var doc = await _context.Documents
                .FirstOrDefaultAsync(id=>id.Title==name);

            var mapped = _mapper.Map<DocumentDto>(doc);

            return mapped;
        }

        public async ValueTask<int> InsertAsync(DocumentDto entity)
        {
            var mapped = _mapper.Map<Document>(entity);

            await _context.Documents.AddAsync(mapped);

            return await _context.SaveChangesAsync();
        }

        public async ValueTask<int> UpdateAsync(DocumentDto entity)
        {
            var mapped = _mapper.Map<Document>(entity);

            _context.Attach(mapped);

            _context.Entry(mapped).State = EntityState.Modified;

            var x = await _context.SaveChangesAsync();

            return x;
        }
    }
}
