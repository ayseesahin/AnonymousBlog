using System.Reflection;
using AnonymousBlog.Service.Services.Abstractions;
using AnonymousBlog.Service.Services.Concrete;
using Microsoft.Extensions.DependencyInjection;

namespace AnonymousBlog.Service.Extensions
{
	public static class ServiceLayerExtensions
	{
        public static IServiceCollection LoadServiceLayerExtension(this IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly();
            services.AddScoped<IArticleService, ArticleService>();
            services.AddScoped<ICategoryService, CategoryService>();

            services.AddAutoMapper(assembly);
            return services;
        }
    }
}

