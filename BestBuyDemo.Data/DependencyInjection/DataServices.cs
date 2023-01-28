using BestBuyDemo.Data.DapperWrapper;
using BestBuyDemo.Data.Repositories;
using BestBuyDemo.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace BestBuyDemo.Data.DependencyInjection
{
    public static class DataServices
    {
        public static IServiceCollection InjectDataServices(this IServiceCollection services, IConfig config)
        {
            if (services == null)
                throw new ApplicationException(nameof(services));

            services.AddSingleton(config);

            services.AddSingleton<IDbConnectionFactory, DbConnectionFactory>();

            services.AddTransient<IDapperWrapper, DapperWrapper.DapperWrapper>();

            services.AddScoped<IProductRepository, ProductRepository>();

            return services;
        }
    }
}
