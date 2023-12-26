using MushRoom.Domain.Common;
using MushRoom.Domain.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MushRoom.Domain.Entities
{
    public class BlogPost : EntityBase<Guid>
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Like> Likes { get; set; }
        public ICollection<BlogPostTag> BlogPostTags { get; set; }
    }
}
