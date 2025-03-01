using ContasFinanceiras.Domain.Entities;

namespace ContasFinanceiras.Appplication.Repositories
{
    public interface IAnexoRepository
    {
        Task<Anexo?> ObterPorIdAsync(Guid id);
        Task<IEnumerable<Anexo>> ObterPorContaIdAsync(Guid contaFinanceiraId);
        Task AdicionarAsync(Anexo anexo);
        Task RemoverAsync(Guid id);
    }
}
