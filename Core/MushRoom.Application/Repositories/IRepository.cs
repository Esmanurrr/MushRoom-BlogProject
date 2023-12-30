using Microsoft.EntityFrameworkCore;
using MushRoom.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MushRoom.Application.Repositories
{
    public interface IRepository<T, TKey> where T: EntityBase<TKey>
    {
        DbSet<T> Table {get; set;}
    }
}
