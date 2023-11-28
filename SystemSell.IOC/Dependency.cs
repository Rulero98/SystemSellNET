using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SystemSell.DALL.DBContext;
using Microsoft.EntityFrameworkCore;
//using SystemSell.DALL.Implementation;
//using SystemSell.DALL.Interfaces;
//using SystemSell.BLL.Interfaces;
//using SystemSell.BLL.Interfaces;

namespace SystemSell.IOC
{
    public static class Dependency
    {
        public static void InjectDependency(this IServiceCollection services, IConfiguration configuration) 
        {
            services.AddDbContext<DBVENTAContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("ChainSQL"));
            });
        }
    }
}
