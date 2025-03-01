using ContasFinanceiras.Domain.Entities;

namespace ContasFinanceiras.Appplication.Repositories
{
    public interface ICarteiraRepository
    {
        Task<Carteira?> ObterPorIdAsync(Guid id);
        Task<IEnumerable<Carteira>> ObterTodasAsync();
        Task AdicionarAsync(Carteira carteira);
        Task AtualizarAsync(Carteira carteira);
        Task RemoverAsync(Guid id);
    }
}
