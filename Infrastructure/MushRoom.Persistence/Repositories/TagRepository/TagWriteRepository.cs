using MushRoom.Domain.Entities;
using MushRoom.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MushRoom.Persistence.Repositories.TagRepository
{
    public class TagWriteRepository : WriteRepository<Tag, Guid>
    {
        public TagWriteRepository(MushRoomDbContext dbContext) : base(dbContext)
        {
        }
    }
}
