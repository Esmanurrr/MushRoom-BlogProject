using MediatR;
using MushRoom.Application.Features.Queries.TagQueries.GetById;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MushRoom.Application.Features.Queries.CommentQueries.GetById
{
    public class GetByIdCommentQueryRequest<TKey> : IRequest<GetByIdCommentQueryResponse>
    {
        public TKey Id { get; set; }
    }
}
