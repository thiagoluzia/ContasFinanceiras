using ContasFinanceiras.Appplication.Repositories;
using ContasFinanceiras.Domain.Entities;
using ContasFinanceiras.Infrastructure.Data;

namespace ContasFinanceiras.Infrastructure.Repositories
{
    public class AnexoRepository : RepositoryBase<Anexo>, IAnexoRepository
    {
        public AnexoRepository(AppDbContext context) : base(context)
        {
        }
    }
}
