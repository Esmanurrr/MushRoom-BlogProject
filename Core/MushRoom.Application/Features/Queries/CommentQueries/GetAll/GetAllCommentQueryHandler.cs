using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MushRoom.Application.Repositories.CommentRepository;
using MushRoom.Domain.Entities;
using MushRoom.Application.Features.Queries.TagQueries.GetAll;
using MushRoom.Application.Repositories.TagRepository;

namespace MushRoom.Application.Features.Queries.CommentQueries.GetAll
{
    public class GetAllCommentQueryHandler:  IRequestHandler<GetAllCommentQueryRequest, List<GetAllCommentQueryResponse>>
    {
        private readonly ICommentReadRepository _commentReadRepository;

        public GetAllCommentQueryHandler(ICommentReadRepository commentReadRepository)
        {
            _commentReadRepository = commentReadRepository;
        }

        public async Task<List<GetAllCommentQueryResponse>> Handle(GetAllCommentQueryRequest request, CancellationToken cancellationToken)
        {

            List<Comment> comments = _commentReadRepository.GetAll();
            List<GetAllCommentQueryResponse> allComment = new List<GetAllCommentQueryResponse>();

            foreach (Comment comment in comments)
            {
                GetAllCommentQueryResponse obj = new()
                {
                    Content = comment.Content,
                    AppUserId = comment.AppUserId,
                    BlogPostId = comment.BlogPostId,
                    UserName = comment.AppUser?.FirstName + " " + comment.AppUser?.SurName // tekrar bak
                };
                allComment.Add(obj);

            }
            //return allComment;
            return await Task.FromResult(allComment);

        }
    }
}
