using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MushRoom.Persistence.Contexts
{
    public class BlogIdentityDbContextFactory:IDesignTimeDbContextFactory<BlogIdentityDbContext>
    {
        public BlogIdentityDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                 .SetBasePath($"{Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName}\\Presentation\\MushRoom.API\\")
                 .AddJsonFile("appsettings.json")
                 .Build();

            var optionsBuilder = new DbContextOptionsBuilder<BlogIdentityDbContext>();

            var connectionString = configuration.GetConnectionString("Team4Ever");


            optionsBuilder.UseNpgsql(connectionString);

            return new BlogIdentityDbContext(optionsBuilder.Options);
        }
    }
    
}


