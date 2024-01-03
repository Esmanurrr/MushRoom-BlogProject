using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MushRoom.Domain.Entities;
using MushRoom.Domain.Identity;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MushRoom.Persistence.Contexts
{
    public class BlogIdentityDbContext : IdentityDbContext<AppUser>
    {
        
        public BlogIdentityDbContext(DbContextOptions<BlogIdentityDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.Ignore<BlogPost>();
            modelBuilder.Ignore<Comment>();
            modelBuilder.Ignore<Like>();
            modelBuilder.Ignore<Tag>();
            modelBuilder.Ignore<BlogPostTag>();

            base.OnModelCreating(modelBuilder);
        }
    }

     
    
}