using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MushRoom.Application.Features.Queries.BlogPostQueries
{
    public class GetAllBlogPostQueryRequest: IRequest<List<GetAllBlogPostQueryResponse>>
    {
    }
}
