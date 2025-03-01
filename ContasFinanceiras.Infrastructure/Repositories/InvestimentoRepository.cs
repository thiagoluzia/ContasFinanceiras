using ContasFinanceiras.Appplication.Repositories;
using ContasFinanceiras.Domain.Entities;
using ContasFinanceiras.Infrastructure.Data;

namespace ContasFinanceiras.Infrastructure.Repositories
{
    public class InvestimentoRepository : RepositoryBase<Investimento>, IInvestimentoRepository
    {
        public InvestimentoRepository(AppDbContext context) : base(context)
        {
        }
    }
}
