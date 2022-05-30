using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Data.Extension
{
    public static class ConnectionConfiguration
    {
        public static void RegisterDBContext(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<DbContext>(options => options.UseNpgsql(config.GetConnectionString("DefaultConnection"),
            getAssembly => getAssembly.MigrationsAssembly(typeof(DbContext).Assembly.FullName)
            ));
        }
    }
}
