using MushRoom.Application.Repositories.CommentRepository;
using MushRoom.Domain.Entities;
using MushRoom.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MushRoom.Persistence.Repositories.CommentRepository
{
    public class CommentReadRepository : ReadRepository<Comment, Guid>, ICommentReadRepository
    {
        public CommentReadRepository(MushRoomDbContext dbContext) : base(dbContext)
        {
        }
    }
}
