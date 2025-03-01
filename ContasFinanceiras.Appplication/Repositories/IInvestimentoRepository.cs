using ContasFinanceiras.Domain.Entities;

namespace ContasFinanceiras.Appplication.Repositories
{
    public interface IInvestimentoRepository
    {
        Task<Investimento?> ObterPorIdAsync(Guid id);
        Task<IEnumerable<Investimento>> ObterTodosAsync();
        Task AdicionarAsync(Investimento investimento);
        Task AtualizarAsync(Investimento investimento);
        Task RemoverAsync(Guid id);
    }
}
