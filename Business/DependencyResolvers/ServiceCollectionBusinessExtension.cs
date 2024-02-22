using DataAccess.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers
{
    public static class ServiceCollectionBusinessExtension
    {

        public static IServiceCollection AddBusinessServices(this IServiceCollection services, IConfiguration configuration)
        {


            services.AddDbContext<KodlamaIoContext>(options => options.UseSqlServer(

                configuration.GetConnectionString("DefaultConnection")
                ));

            return services;
        }
    }
}
