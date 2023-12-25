using MushRoom.Domain.Common;
using MushRoom.Domain.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MushRoom.Domain.Entities
{
    public class Like : EntityBase<Guid>
    {
        public Guid UserId { get; set; }
        public User User { get; set; }
        public Guid BlogPostId { get; set; }
        public BlogPost BlogPost { get; set; }
        public Guid CommentId { get; set; }
        public Comment Comment { get; set; }
    }
}
