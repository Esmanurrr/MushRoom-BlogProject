using MediatR;
using MushRoom.Application.Repositories.CommentRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MushRoom.Application.Features.Queries.CommentQueries.GetById
{
    public class GetByIdCommentQueryHandler : IRequestHandler<GetByIdCommentQueryRequest<Guid>, GetByIdCommentQueryResponse>
    {
        private readonly ICommentReadRepository _commentReadRepository;

        public GetByIdCommentQueryHandler(ICommentReadRepository commentReadRepository)
        {
            _commentReadRepository = commentReadRepository;
        }

        public async Task<GetByIdCommentQueryResponse> Handle(GetByIdCommentQueryRequest<Guid> request, CancellationToken cancellationToken)
        {
            var comment = _commentReadRepository.GetById(request.Id);
            return new() { Content = comment.Content };
        }
    }
}
