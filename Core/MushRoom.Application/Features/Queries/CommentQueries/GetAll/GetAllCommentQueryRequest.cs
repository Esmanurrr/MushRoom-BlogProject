using MediatR;
using MushRoom.Application.Features.Queries.TagQueries.GetAll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MushRoom.Application.Features.Queries.CommentQueries.GetAll
{
  public class GetAllCommentQueryRequest : IRequest<List<GetAllCommentQueryResponse>>
    {

    }
}
