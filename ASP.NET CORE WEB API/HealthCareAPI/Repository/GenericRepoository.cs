using HealthCareAPI.Database;
using Microsoft.EntityFrameworkCore;

namespace HealthCareAPI.Repository
{
    public class GenericRepoository<T> : IGenericRepository<T> where T : class
    {
        private readonly AppDbContext _context;

        public GenericRepoository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<T>> GetAll()
      => await _context.Set<T>().ToListAsync();

        public async Task<T> GetById(int id)
            => await _context.Set<T>().FindAsync(id);

        public async Task Add(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Update(T entity)
        {
            _context.Set<T>().Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var entity = await GetById(id);
            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}
