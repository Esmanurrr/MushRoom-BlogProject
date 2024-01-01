using MediatR;
using MushRoom.Application.Repositories.BlogPostRepository;
using MushRoom.Domain.Entities;
using MushRoom.Domain.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

        public Task<AddBlogPostCommandResponse> Handle(AddBlogPostCommandRequest request, CancellationToken cancellationToken)
        {
            var blogPost = new BlogPost()
            {
                Id = Guid.NewGuid(),
                Title = request.Title,
                Content = request.Content,
                CreatedByUserId = "Liva",
                /*User = request.User,
                UserId= request.User.Id,
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                IsDeleted=false*/

            };

          _blogPostWriteRepository.Add(blogPost);
          _blogPostWriteRepository.SaveChanges();

            return Task.FromResult(new AddBlogPostCommandResponse()); 
        }
    }
}
