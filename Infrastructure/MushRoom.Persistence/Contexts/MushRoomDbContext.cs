using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
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
        DbSet<BlogPost> BlogPosts { get; set; }
        DbSet<Comment> Comments { get; set; }
        DbSet<Like> Likes { get; set; }
        DbSet<Tag> Tags { get; set; }
        DbSet<BlogPostTag> BlogPostTags { get; set; }
        public MushRoomDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);
        }
    }
}
