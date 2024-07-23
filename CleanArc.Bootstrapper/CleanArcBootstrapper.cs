using CleanArc.Application.Services;
using CleanArc.Contract;
using CleanArc.Domain.Repositories;
using CleanArc.Infrastructure;
using CleanArc.Infrastructure.Persistence.Memory;
using CleanArc.Infrastructure.Persistence.Memory.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArc.Bootstrapper
{
    public class CleanArcBootstrapper
    {
        public static void Init(IServiceCollection services)
        {
            services.AddTransient<IOrderService, OrderService>();
            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<IOrderRepository, OrderRepository>();
            services.AddTransient<IProductRepository, ProductRepository>();


            services.AddScoped<ISmsService, SmsService>();
            services.AddSingleton<Context>();
        }

    }
}
