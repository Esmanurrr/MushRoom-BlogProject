using MediatR;
using Microsoft.AspNetCore.Http;
using MushRoom.Application.Features.Commands.CommentCommands.Add;
using MushRoom.Application.Repositories.BlogPostRepository;
using MushRoom.Domain.Entities;
using MushRoom.Domain.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace MushRoom.Application.Features.Commands.BlogPostCommands.Add
{
    public class AddBlogPostCommandHandler : IRequestHandler<AddBlogPostCommandRequest, AddBlogPostCommandResponse>
    {
        private readonly IBlogPostWriteRepository _blogPostWriteRepository;

        public AddBlogPostCommandHandler(IBlogPostWriteRepository blogPostWriteRepository)
        {
            _blogPostWriteRepository = blogPostWriteRepository;
        }

        public async Task<AddBlogPostCommandResponse> Handle(AddBlogPostCommandRequest request, CancellationToken cancellationToken)
        {
            //string currentUserId = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var blogPost = new BlogPost()
            {
                Id = Guid.NewGuid(),
                Title = request.Title,
                Content = request.Content,
                CreatedByUserId = "Liva",
                /*AppUserId = AppUser,
                UserId= request.User.Id,*/
                AppUserId = request.UserId,
                //AppUser = _context.FirstOrDefault(x=>x.AppUserId == )
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                IsDeleted=false

            };

          _blogPostWriteRepository.Add(blogPost);
          _blogPostWriteRepository.SaveChanges();

            var response = new AddBlogPostCommandResponse
            {
                IsSuccess = blogPost.Id != Guid.Empty
            };

            return response;
        }
    }
}
