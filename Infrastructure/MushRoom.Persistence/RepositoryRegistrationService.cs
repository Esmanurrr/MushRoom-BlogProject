using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MushRoom.Domain.Identity;
using MushRoom.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MushRoom.Persistence
{
    public static class RepositoryRegistrationService
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<MushRoomDbContext>();
            services.AddIdentity<User, Role>(options =>
            {
                options.Password.RequiredLength = 3;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
                options.User.RequireUniqueEmail = true;
            }).AddEntityFrameworkStores<MushRoomDbContext>();


        }


    }
}
