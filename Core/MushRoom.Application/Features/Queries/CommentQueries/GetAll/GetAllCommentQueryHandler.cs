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
using Microsoft.AspNetCore.Identity;
using MushRoom.Domain.Identity;
using Microsoft.Extensions.Hosting;

namespace MushRoom.Application.Features.Queries.CommentQueries.GetAll
{
    public class GetAllCommentQueryHandler:  IRequestHandler<GetAllCommentQueryRequest, List<GetAllCommentQueryResponse>>
    {
        private readonly ICommentReadRepository _commentReadRepository;
        private readonly UserManager<AppUser> _userManager;
        public GetAllCommentQueryHandler(ICommentReadRepository commentReadRepository, UserManager<AppUser> userManager)
        {
            _commentReadRepository = commentReadRepository;
            _userManager = userManager;
        }

        public async Task<List<GetAllCommentQueryResponse>> Handle(GetAllCommentQueryRequest request, CancellationToken cancellationToken)
        {

            List<Comment> comments = _commentReadRepository.GetAll();
            List<GetAllCommentQueryResponse> allComment = new List<GetAllCommentQueryResponse>();

            foreach (Comment comment in comments)
            {
                var appUser = await _userManager.FindByIdAsync(comment.AppUserId.ToString());
                string username = $"{appUser?.FirstName} {appUser?.SurName}";
                GetAllCommentQueryResponse obj = new()
                {
                    Content = comment.Content,
                    AppUserId = comment.AppUserId,
                    BlogPostId = comment.BlogPostId,
                    UserName = username,
                };
                allComment.Add(obj);

            }
            //return allComment;
            return await Task.FromResult(allComment);

        }
    }
}
