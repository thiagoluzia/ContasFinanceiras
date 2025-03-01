using Microsoft.Extensions.DependencyInjection;

namespace ContasFinanceiras.Infrastructure.Module
{
    public static class InfrastructureModule
    {
        public static void AddInfrastructureModule(this IServiceCollection services)
        {
            // Aqui podemos adicionar serviços externos como envio de e-mails, storage, etc.
           // Exemplo: services.AddScoped<IEmailService, EmailService>();
        }
    }
}
