using Microsoft.Extensions.DependencyInjection;
using Repository.Implementation.Activity;
using Repository.Implementation.User;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public static class ServiceCollectionExtension
    {
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IActivityRepository, ActivityRepository>();
            services.AddScoped<IUserReposotory, UserRepository>();
        }

    }
}
