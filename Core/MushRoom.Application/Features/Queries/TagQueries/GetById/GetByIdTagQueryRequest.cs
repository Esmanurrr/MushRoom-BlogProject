using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MushRoom.Application.Features.Queries.TagQueries.GetById
{
    public class GetByIdTagQueryRequest<TKey>: IRequest<GetByIdTagQueryResponse>
    {
        public TKey Id { get; set; }
    }
}
