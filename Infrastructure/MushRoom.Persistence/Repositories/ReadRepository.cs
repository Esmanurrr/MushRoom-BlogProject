using Microsoft.EntityFrameworkCore;
using MushRoom.Application.Repositories;
using MushRoom.Domain.Common;
using MushRoom.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MushRoom.Persistence.Repositories
{
    public class ReadRepository<T, TKey> : IReadRepository<T, TKey> where T : EntityBase<TKey>
    {
        private readonly MushRoomDbContext _context;

        public ReadRepository(MushRoomDbContext dbContext)
        {
            _context = dbContext;
        }
        public DbSet<T> Table =>_context.Set<T>();

        public List<T> GetAll()
        {
            return Table.ToList();
        }

        public T GetById(TKey id)
        {
            return Table.Select(x=>x.Id== id).FirstOrDefault();
        }
    }
}
