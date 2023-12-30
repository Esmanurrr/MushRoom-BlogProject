using MushRoom.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MushRoom.Application.Repositories.CommentRepository
{
    public interface ICommentWriteRepository : IWriteRepository<Comment, Guid>
    {
    }
}
