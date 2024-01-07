using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MushRoom.Domain.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MushRoom.Persistence.Configurations
{
    public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            // Primary key
            builder.HasKey(x => x.Id);

            // Indexes for "normalized" username and email, to allow efficient lookups
            builder.HasIndex(u => u.NormalizedUserName).HasName("UserNameIndex").IsUnique();
            builder.HasIndex(u => u.NormalizedEmail).HasName("EmailIndex");


            // A concurrency token for use with the optimistic concurrency checking
            builder.Property(u => u.ConcurrencyStamp).IsConcurrencyToken();

            // Limit the size of columns to use efficient database types
            builder.Property(u => u.UserName).HasMaxLength(256);
            builder.Property(u => u.NormalizedUserName).HasMaxLength(256);
            builder.Property(u => u.Email).HasMaxLength(256);
            builder.Property(u => u.NormalizedEmail).HasMaxLength(256);

            //Firstname
            builder.Property(x => x.FirstName).IsRequired();
            builder.Property(x => x.FirstName).HasMaxLength(70);

            //SurName
            builder.Property(x => x.SurName).IsRequired();
            builder.Property(x => x.SurName).HasMaxLength(70);

            //Gender
            builder.Property(x => x.Gender).IsRequired();
            builder.Property(x => x.Gender).HasConversion<int>();

            //BirthDate
            builder.Property(x => x.BirthDate).IsRequired(false);


            //Relationships

            //Among User and BlogPost
            builder.HasMany(x => x.BlogPosts)
                   .WithOne(x => x.AppUser)
                   .HasForeignKey(x => x.AppUserId);

            //Among User and Comment
            builder.HasMany(x => x.Comments)
                   .WithOne(x => x.AppUser)
                   .HasForeignKey(x => x.AppUserId);

            //Among User and Like
            builder.HasMany(x => x.Likes)
                   .WithOne(x => x.AppUser)
                   .HasForeignKey(x => x.AppUserId);

            builder.ToTable("AppUsers");
         
        }
    }
}
