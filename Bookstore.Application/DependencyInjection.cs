using System;
using Bookstore.Application.Common.Interfaces;
using Bookstore.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Bookstore.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddTransient<IAuthorService, AuthorService>();
            return services;
        }
    }
}

