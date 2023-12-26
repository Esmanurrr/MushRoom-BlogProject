using MushRoom.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MushRoom.Domain.Entities
{
    public class BlogPostTag : ICreatedOn
    {
        public Guid BlogPostId { get; set; }
        public BlogPost BlogPost { get; set; }
        public Guid TagId { get; set; }
        public Tag Tag { get; set; }
        public string? CreatedByUserId { get; set;}
        public DateTimeOffset CreatedOn { get; set; }
    }
}
