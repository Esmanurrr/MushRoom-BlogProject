using MushRoom.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MushRoom.Domain.Common;
using MushRoom.Domain.Entities;

namespace MushRoom.Application.Repositories.BlogPostRepository
{
    public interface IBlogPostReadRepository: IReadRepository<BlogPost, Guid>
    {

    }
}
