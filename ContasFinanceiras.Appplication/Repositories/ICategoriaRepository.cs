using ContasFinanceiras.Domain.Entities;

namespace ContasFinanceiras.Appplication.Repositories
{
    public interface ICategoriaRepository
    {
        Task<Categoria?> ObterPorIdAsync(Guid id);
        Task<IEnumerable<Categoria>> ObterTodasAsync();
        Task AdicionarAsync(Categoria categoria);
        Task AtualizarAsync(Categoria categoria);
        Task RemoverAsync(Guid id);
    }
}
