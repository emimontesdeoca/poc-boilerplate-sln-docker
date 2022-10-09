using Boilerplate.Libraries.Data.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boilerplate.Libraries.Repositories
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddBoilerplateRepositories(this IServiceCollection services)
        {
            services.AddTransient<TodoRepository>();

            return services;
        }

    }
}
