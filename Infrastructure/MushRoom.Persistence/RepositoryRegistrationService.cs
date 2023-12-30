using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MushRoom.Application.Repositories.BlogPostRepository;
using MushRoom.Application.Repositories.CommentRepository;
using MushRoom.Domain.Identity;
using MushRoom.Persistence.Contexts;
using MushRoom.Persistence.Repositories.BlogPostRepository;
using MushRoom.Persistence.Repositories.CommentRepository;
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

            /*string connectionString = services.Configuration.GetSection("Team4Ever").Value;
            services.AddDbContext<MushRoomDbContext>(options =>
            {
                options.UseNpgsql(connectionString);
            });*/

            services.AddIdentity<User,Role>(options =>
            {
                options.Password.RequiredLength = 3;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
                options.User.RequireUniqueEmail = true;
            }).AddEntityFrameworkStores<MushRoomDbContext>();

            services.AddScoped<IBlogPostReadRepository, BlogPostReadRepository>();
            services.AddScoped<IBlogPostWriteRepository, BlogPostWriteRepository>();

        }


    }
}
