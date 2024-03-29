﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MushRoom.Domain.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MushRoom.Persistence.Configurations
{
    public class AppRoleConfiguration
    {/*
        public void Configure(EntityTypeBuilder<AppRole> builder)
        {
            // CreatedByUserId
            builder.Property(x => x.CreatedByUserId).IsRequired();
            builder.Property(x => x.CreatedByUserId).HasMaxLength(75);

            // CreatedOn
            builder.Property(x => x.CreatedOn).IsRequired();

            // ModifiedByUserId
            builder.Property(x => x.ModifiedByUserId).IsRequired(false);
            builder.Property(x => x.ModifiedByUserId).HasMaxLength(75);

            // LastModifiedOn
            builder.Property(x => x.ModifiedOn).IsRequired();


            //Relationships

            //Among AppUser and BlogPost
            builder.HasMany(x => x.AppUsers)
                   .WithOne(x => x.AppRole)
                   .HasForeignKey(x => x.AppRoleId);

            builder.ToTable("Role");
        }*/
    }
}
