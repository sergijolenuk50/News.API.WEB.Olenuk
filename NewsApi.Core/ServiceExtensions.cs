using Microsoft.Extensions.DependencyInjection;
using NewsApi.Core.AutoMapper;
using NewsApi.Core.Interfaces;
using NewsApi.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NewsApi.Core
{
    public static class ServiceExtensions
    {
        public static void AddCoreServices(this IServiceCollection service)
        {
            service.AddScoped<INewsServices, NewsServices>();
            service.AddScoped<IUsersServices, UsersServices>();

        }

        public static void AddMapping(this IServiceCollection service)
        {
            service.AddAutoMapper(typeof(AutoMapperNewsProFile));
        }
    }

   
}
