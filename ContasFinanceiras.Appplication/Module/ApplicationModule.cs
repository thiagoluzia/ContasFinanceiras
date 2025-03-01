using Microsoft.Extensions.DependencyInjection;

namespace ContasFinanceiras.Appplication.Module
{
    public static class ApplicationModule
    {
        public static void AddApplicationModule(this IServiceCollection services)
        {
            //services.AddScoped<IContaFinanceiraService, ContaFinanceiraService>();
            //services.AddScoped<INotificacaoService, NotificacaoService>();
        }
    }
}
