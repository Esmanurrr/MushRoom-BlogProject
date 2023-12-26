using Microsoft.AspNetCore.Identity;
using MushRoom.Domain.Common;
using MushRoom.Domain.Entities;
using MushRoom.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MushRoom.Domain.Identity
{
    public class User : IdentityUser<Guid>, IEntityBase<Guid>, ICreatedOn , IModifiedOn
    {
        public string FirstName { get; set; } 
        public string SurName { get; set; }

        public DateTimeOffset? BirthDate { get; set; }
        public Gender Gender { get; set; }

        public string CreatedByUserId { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
        public string? ModifiedByUserId { get; set; }
        public DateTimeOffset ModifiedOn { get; set; }

        public ICollection<BlogPost> BlogPosts { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Like> Likes { get; set; }

        public Guid RoleId { get; set; }
        public Role Role { get; set; }


    }
}
