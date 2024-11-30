using Dechode.Persistance.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dechode.Persistance
{
    public static class RegisterServices
    {
        public static void AddPersistenceRegister(this IServiceCollection services)
        {
            services.AddDbContext<DechodeDbContext>(options =>
            {
                ConfigurationBuilder configurationBuilder = new();
                var builder = configurationBuilder.AddJsonFile("appsettings.json").Build();

                options.UseLazyLoadingProxies()
                       .UseSqlServer(builder.GetConnectionString("default"));
            });

            //aşağıda isə repoların registrasiyası icra oluna bilər. Yazdıqca olunmalıdır. 
        }
    }
}
