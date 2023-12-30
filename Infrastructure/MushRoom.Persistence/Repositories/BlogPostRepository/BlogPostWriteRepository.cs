using MushRoom.Domain.Entities;
using MushRoom.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace MushRoom.Persistence.Repositories.BlogPostRepository
{
    public class BlogPostWriteRepository : WriteRepository<BlogPost, Guid>
    {
        public BlogPostWriteRepository(MushRoomDbContext dbContext) : base(dbContext)
        {
        }
    }
}
