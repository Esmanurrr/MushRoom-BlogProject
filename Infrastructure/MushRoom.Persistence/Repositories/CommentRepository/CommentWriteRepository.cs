﻿using MushRoom.Domain.Entities;
using MushRoom.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MushRoom.Persistence.Repositories.CommentRepository
{
    public class CommentWriteRepository : WriteRepository<Comment, Guid> 
    {
        public CommentWriteRepository(MushRoomDbContext dbContext) : base(dbContext)
        {
        }
    }
}
