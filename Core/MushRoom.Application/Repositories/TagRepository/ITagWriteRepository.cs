using MushRoom.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MushRoom.Application.Repositories.TagRepository
{
    public interface ITagWriteRepository : IWriteRepository<Tag, Guid>
    {
    }
}
