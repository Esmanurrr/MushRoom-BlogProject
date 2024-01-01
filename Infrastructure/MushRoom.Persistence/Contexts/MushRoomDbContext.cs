using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MushRoom.Domain.Common;
using MushRoom.Domain.Entities;
using MushRoom.Domain.Identity;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MushRoom.Persistence.Contexts
{
    public class MushRoomDbContext : IdentityDbContext<User, Role, Guid>
    {
        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Like> Likes { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<BlogPostTag> BlogPostTags { get; set; }
        public MushRoomDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            var entries = ChangeTracker.Entries();

            foreach (var entry in entries)
            {
                if (entry.State == EntityState.Added)
                    ((ICreatedOn)entry.Entity).CreatedOn = DateTime.UtcNow;

                if (entry.State == EntityState.Modified)
                    ((IModifiedOn)entry.Entity).ModifiedOn = DateTime.UtcNow;

            }

            return base.SaveChanges();
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseNpgsql(Configurations.GetString("ConnectionStrings:PostgreSQL"));
        //}




    }
}
