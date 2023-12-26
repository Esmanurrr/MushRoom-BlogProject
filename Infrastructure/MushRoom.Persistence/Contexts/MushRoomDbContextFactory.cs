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
    public class MushRoomDbContextFactory : IDesignTimeDbContextFactory<MushRoomDbContext>
    {
        public MushRoomDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                 .SetBasePath($"{Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName}\\Presentation\\MushRoom.API\\")
                 .AddJsonFile("appsettings.json")
                 .Build();

            var optionsBuilder = new DbContextOptionsBuilder<MushRoomDbContext>();

            var connectionString = configuration.GetSection("Team4Ever").Value;


            optionsBuilder.UseNpgsql(connectionString);

            return new MushRoomDbContext(optionsBuilder.Options); 
        }
    }
}
