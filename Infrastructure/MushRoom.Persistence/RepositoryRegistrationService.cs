using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MushRoom.API.Validators;
using MushRoom.Application;
using MushRoom.Application.Repositories.BlogPostRepository;
using MushRoom.Application.Repositories.CommentRepository;
using MushRoom.Application.Repositories.TagRepository;
using MushRoom.Domain.Identity;
using MushRoom.Persistence.Contexts;
using MushRoom.Persistence.Repositories.BlogPostRepository;
using MushRoom.Persistence.Repositories.CommentRepository;
using MushRoom.Persistence.Repositories.TagRepository;
using MushRoom.Persistence.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MushRoom.Persistence
{
    public static class RepositoryRegistrationService
    {
        public static void AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
             //services.AddDbContext<MushRoomDbContext>();

            /*string connectionString = services.Configuration.GetSection("Team4Ever").Value;
            services.AddDbContext<MushRoomDbContext>(options =>
            {
                options.UseNpgsql(connectionString);
            });*/

            //Database Connection
            var connectionString = configuration.GetConnectionString("Team4Ever");

            services.AddDbContext<MushRoomDbContext>(options =>
            {
                options.UseNpgsql(connectionString);
            });
            services.AddDbContext<BlogIdentityDbContext>(options =>
            {
                options.UseNpgsql(connectionString);
            });

            //Identity Manager
            services.AddIdentity<AppUser, IdentityRole>(options =>
            {
                options.Password.RequiredLength = 3;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
                options.User.RequireUniqueEmail = true;
            }).AddEntityFrameworkStores<BlogIdentityDbContext>();

            //Validation System
            services.AddControllers().AddFluentValidation(s =>
            {
                s.RegisterValidatorsFromAssemblyContaining<RegistrationModelValidator>();
                s.RegisterValidatorsFromAssemblyContaining<LoginModelValidator>();
                s.RegisterValidatorsFromAssemblyContaining<AddTagCommandRequestValidator>();
                s.RegisterValidatorsFromAssemblyContaining<AddBlogPostCommandRequestValidator>();
                s.RegisterValidatorsFromAssemblyContaining<AddCommentCommandRequestValidator>();
            });


            //Repository Services
            services.AddScoped<IBlogPostReadRepository, BlogPostReadRepository>();
            services.AddScoped<IBlogPostWriteRepository, BlogPostWriteRepository>();
            services.AddScoped<ICommentReadRepository, CommentReadRepository>();
            services.AddScoped<ICommentWriteRepository, CommentWriteRepository>();
            services.AddScoped<ITagReadRepository, TagReadRepository>();
            services.AddScoped<ITagWriteRepository, TagWriteRepository>();
        }


    }
}
