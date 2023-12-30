using MushRoom.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MushRoom.Application.Repositories
{
    public interface IReadRepository<T, TKey>: IRepository<T, TKey> where T : EntityBase<TKey>
    {
        List<T> GetAll();
        T GetById(TKey id);
    }
}
