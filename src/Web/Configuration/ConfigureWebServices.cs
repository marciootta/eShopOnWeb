using MediatR;
using Microsoft.eShopWeb.Web.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Microsoft.eShopWeb.Web.Configuration
{
    public static class ConfigureWebServices
    {
        public static IServiceCollection AddWebServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddMediatR(typeof(BasketViewModelService).Assembly);
            services.AddScoped<BasketViewModelService>();
            services.AddScoped<CatalogViewModelService>();
            services.AddScoped<CatalogItemViewModelService>();
            services.Configure<CatalogSettings>(configuration);
            services.AddScoped<CachedCatalogViewModelService>();
            services.AddScoped<OrderViewModelService>();
            return services;
        }
    }
}
