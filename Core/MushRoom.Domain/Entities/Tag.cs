using MushRoom.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MushRoom.Domain.Entities
{
    public class Tag : EntityBase<Guid>
    {
        public string Name { get; set; }
        public ICollection<BlogPostTag> BlogPostTags { get; set; }

    }
}
