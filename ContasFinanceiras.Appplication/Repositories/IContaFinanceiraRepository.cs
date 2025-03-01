using ContasFinanceiras.Domain.Entities;

namespace ContasFinanceiras.Appplication.Repositories
{
    public interface IContaFinanceiraRepository
    {
        Task<ContaFinanceira?> ObterPorIdAsync(Guid id);
        Task<IEnumerable<ContaFinanceira>> ObterTodasAsync();
        Task<IEnumerable<ContaFinanceira>> ObterPorVencimentoAsync(DateTime data);
        Task<IEnumerable<ContaFinanceira>> ObterPendentesAsync();
        Task AdicionarAsync(ContaFinanceira contaFinanceira);
        Task AtualizarAsync(ContaFinanceira contaFinanceira);
        Task RemoverAsync(Guid id);
    }
}
