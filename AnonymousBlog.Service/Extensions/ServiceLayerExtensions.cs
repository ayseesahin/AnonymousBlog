using AnonymousBlog.Service.Services.Abstractions;
using AnonymousBlog.Service.Services.Concrete;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AnonymousBlog.Service.Extensions
{
	public static class ServiceLayerExtensions
	{
        public static IServiceCollection LoadServiceLayerExtension(this IServiceCollection services)
        {
            services.AddScoped<IArticleService, ArticleService>();
            return services;
        }
    }
}

