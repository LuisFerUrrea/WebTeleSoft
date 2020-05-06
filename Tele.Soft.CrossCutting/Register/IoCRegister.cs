using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Tele.Soft.Application.Contracts.Services;
using Tele.Soft.Application.Services;
using Tele.Soft.DataAccess.Contracts.Repositories;
using Tele.Soft.DataAccess.Repositories;

namespace Tele.Soft.CrossCutting.Register
{
    public static class IoCRegister
    {
        public static IServiceCollection AddRegistration(this IServiceCollection services)
        {
            AddRegisterServices(services);
            AddRegisterRepositories(services);           
            return services;
        }

        public static IServiceCollection AddRegisterServices(IServiceCollection services)
        {
            services.AddTransient<IClienteService, ClienteService>();
          
            return services;
        }

        public static IServiceCollection AddRegisterRepositories(IServiceCollection services)
        {
            services.AddTransient<IClienteRepository, ClienteRepository>();
           
            return services;
        }
    }
}
