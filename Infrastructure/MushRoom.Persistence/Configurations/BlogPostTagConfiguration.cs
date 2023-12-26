using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MushRoom.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MushRoom.Persistence.Configurations
{
    public class BlogPostTagConfiguration : IEntityTypeConfiguration<BlogPostTag>
    {
        public void Configure(EntityTypeBuilder<BlogPostTag> builder)
        {
            builder.HasKey(x => new { x.BlogPostId, x.TagId });

            // Relationships

            // Among BlogPostTag and Tag
            builder.HasOne(x => x.BlogPost)
                   .WithMany(x => x.BlogPostTags)
                   .HasForeignKey(x => x.BlogPostId);

            // Among BlogPostTag and BlogPost
            builder.HasOne(x => x.Tag)
                   .WithMany(x => x.BlogPostTags)
                   .HasForeignKey(x => x.TagId);

            // CreatedByUserId
            builder.Property(x => x.CreatedByUserId).IsRequired();
            builder.Property(x => x.CreatedByUserId).HasMaxLength(75);

            // CreatedOn
            builder.Property(x => x.CreatedOn).IsRequired();

            builder.ToTable("BlogPostTags");
        }
    }
}
