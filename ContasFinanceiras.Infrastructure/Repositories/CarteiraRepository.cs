using ContasFinanceiras.Appplication.Repositories;
using ContasFinanceiras.Domain.Entities;
using ContasFinanceiras.Infrastructure.Data;

namespace ContasFinanceiras.Infrastructure.Repositories
{
    public class CarteiraRepository : RepositoryBase<Carteira>, ICarteiraRepository
    {
        public CarteiraRepository(AppDbContext context) : base(context)
        {
        }
    }
}
