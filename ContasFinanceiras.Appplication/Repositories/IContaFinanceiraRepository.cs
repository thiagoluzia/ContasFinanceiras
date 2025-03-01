using ContasFinanceiras.Domain.Entities;

namespace ContasFinanceiras.Appplication.Repositories
{
    public interface IContaFinanceiraRepository : IRepository<ContaFinanceira>
    {
        Task<IEnumerable<ContaFinanceira>> ObterPorVencimentoAsync(DateTime data);
        Task<IEnumerable<ContaFinanceira>> ObterPendentesAsync();
    }
}
