using MushRoom.Domain.Common;
using MushRoom.Domain.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MushRoom.Domain.Entities
{
    public class Comment : EntityBase<Guid>
    {
        public string Content { get; set; }
        public Guid AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public Guid BlogPostId { get; set; }
        public BlogPost BlogPost { get; set; }
        public ICollection<Like> Likes { get; set; }
    }
}
