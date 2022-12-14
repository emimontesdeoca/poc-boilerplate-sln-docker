using Boilerplate.Libraries.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boilerplate.Libraries.Services
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddBoilerplateServices(this IServiceCollection services)
        {
            services.AddTransient<TodoService>();

            return services;
        }

    }
}
