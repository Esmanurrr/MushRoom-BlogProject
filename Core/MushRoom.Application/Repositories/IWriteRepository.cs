using MushRoom.Domain.Common;
using MushRoom.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MushRoom.Application.Repositories
{
    public interface IWriteRepository<T, TKey>: IRepository<T, TKey> where T: EntityBase<TKey>
    {
        void Add(T entity);
        void Delete(TKey id);
        void Edit(TKey entity);
        void SaveChanges();
    }
}
