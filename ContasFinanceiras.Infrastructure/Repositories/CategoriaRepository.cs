using ContasFinanceiras.Appplication.Repositories;
using ContasFinanceiras.Domain.Entities;
using ContasFinanceiras.Infrastructure.Data;

namespace ContasFinanceiras.Infrastructure.Repositories
{
    public class CategoriaRepository : RepositoryBase<Categoria>, ICategoriaRepository
    {
        public CategoriaRepository(AppDbContext context) : base(context)
        {
        }
    }
}
