using ContasFinanceiras.Appplication.Repositories;
using ContasFinanceiras.Domain.Entities;
using ContasFinanceiras.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace ContasFinanceiras.Infrastructure.Repositories
{
    public class ContaFinanceiraRepository : RepositoryBase<ContaFinanceira>, IContaFinanceiraRepository
    {
        public ContaFinanceiraRepository(AppDbContext context) : base(context)
        {
        }


        public async Task<IEnumerable<ContaFinanceira>> ObterPendentesAsync()
        {
            return await _dbSet.Where(c => !c.Pago).ToListAsync();
        }

        public async Task<IEnumerable<ContaFinanceira>> ObterPorVencimentoAsync(DateTime data)
        {
            return await _dbSet.Where(c => c.DataVencimento.Date == data.Date).ToListAsync();
        }
    }
}
