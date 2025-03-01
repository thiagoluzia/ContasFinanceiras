
using ContasFinanceiras.Appplication.Module;
using ContasFinanceiras.Infrastructure.Module;


namespace ContasFinanceiras.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Registrar módulos de injeção de dependências
            builder.Services.AddPersistenceModule(builder.Configuration);
            builder.Services.AddApplicationModule();
            builder.Services.AddInfrastructureModule();


            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
