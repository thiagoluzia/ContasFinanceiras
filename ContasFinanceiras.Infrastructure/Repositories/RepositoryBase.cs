using ContasFinanceiras.Appplication.Repositories;
using ContasFinanceiras.Domain.Entities;
using ContasFinanceiras.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace ContasFinanceiras.Infrastructure.Repositories
{
    public class RepositoryBase<T> : IRepository<T> where T : BaseEntity
    {
        protected readonly AppDbContext _context;
        protected readonly DbSet<T> _dbSet;


        public RepositoryBase(AppDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }


        public async  Task AdicionarAsync(T entidade)
        {
            await _dbSet.AddAsync(entidade);
            await _context.SaveChangesAsync();
        }

        public async Task AtualizarAsync(T entidade)
        {
            _dbSet.Update(entidade);
            await _context.SaveChangesAsync();
        }

        public async Task<T?> ObterPorIdAsync(Guid id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<IEnumerable<T>> ObterTodosAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task RemoverAsync(Guid id)
        {
            var entidade = await _dbSet.FindAsync(id);
            if (entidade != null)
            {
                _dbSet.Remove(entidade);
                await _context.SaveChangesAsync();
            }
        }
    }
}
