using ThomasGregTest.Application.Services;
using ThomasGregTest.Domain.Interfaces.Repositories;
using ThomasGregTest.Domain.Interfaces.Services;
using ThomasGregTest.Domain.Models.Cliente;
using ThomasGregTest.Domain.Models.Logradouro;
using ThomasGregTest.Infra.CrossCutting.Ioc;
using ThomasGregTest.Infra.Data.Repositories;
using ThomasGregTest.Infra.UnitOfWork;

namespace ThomasGregTest.API.Configuration
{
    public static class ConfigureDependency
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            
            services.AddSingleton<ApplicationDbContext>();

            services.AddRouting(context => context.LowercaseUrls = true);
            services.AddControllersWithViews().AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles;
                options.JsonSerializerOptions.WriteIndented = true;
            });

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            services.AddScoped<IClienteService, ClienteService>();
            services.AddScoped<ILogradouroService, LogradouroService>();
            //services.AddSingleton<IClienteService>();
            //services.AddSingleton<ILogradouroService>();

            services.AddScoped<IUnit, Unit>();
            services.AddScoped<IClienteRepository<Cliente>, ClienteRepository>();
            services.AddScoped<ILogradouroRepository<Logradouro>, LogradouroRepository>();
            //services.AddScoped<IGenericRepository<ClienteResponse>, GenericRepository<ClienteResponse>>();
            //services.AddScoped<IGenericRepository<LogradouroResponse>, GenericRepository<LogradouroResponse>>();



            return services;
        }
    }
}
