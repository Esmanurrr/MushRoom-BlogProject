using MushRoom.Application.Repositories.BlogPostRepository;
using MushRoom.Domain.Entities;
using MushRoom.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MushRoom.Persistence.Repositories.BlogPostRepository
{
    public class BlogPostReadRepository : ReadRepository<BlogPost, Guid>, IBlogPostReadRepository
    {
        public BlogPostReadRepository(MushRoomDbContext dbContext) : base(dbContext)
        {
        }
    }
}
