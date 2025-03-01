using ContasFinanceiras.Appplication.Repositories;
using ContasFinanceiras.Infrastructure.Data;
using ContasFinanceiras.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ContasFinanceiras.Infrastructure.Module
{
    public static class PersistenceModule
    {
        public static void AddPersistenceModule(this IServiceCollection services, IConfiguration configuration )
        {
            // Configuração do banco de dados
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(connectionString));

            // Injeção de dependência dos repositórios
            services.AddScoped<IContaFinanceiraRepository, ContaFinanceiraRepository>();
            services.AddScoped<ICategoriaRepository, CategoriaRepository>();
            services.AddScoped<IInvestimentoRepository, InvestimentoRepository>();
            services.AddScoped<ICarteiraRepository, CarteiraRepository>();
            services.AddScoped<IAnexoRepository, AnexoRepository>();
        }
    }
}
