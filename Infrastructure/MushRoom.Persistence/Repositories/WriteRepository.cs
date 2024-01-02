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
    public class WriteRepository<T,TKey> : IWriteRepository<T, TKey> where T : EntityBase<TKey>
    {
        private readonly MushRoomDbContext _context;

        public WriteRepository(MushRoomDbContext dbContext)
        {
            _context = dbContext;
        }
        public DbSet<T> Table => _context.Set<T>();

        public void Add(T entity)
        {
            Table.Add(entity);
        }

        public void Delete(TKey id)
        {
            var entity = Table.FirstOrDefault(x=> EqualityComparer<TKey>.Default.Equals(x.Id, id));
            Table.Remove(entity);
        }
        public void Edit(TKey entity)
        {
        
            _context.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
