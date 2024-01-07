using MediatR;
using MushRoom.Application.Features.Commands.TagCommands.Delete;
using MushRoom.Application.Repositories.BlogPostRepository;
using MushRoom.Application.Repositories.TagRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MushRoom.Application.Features.Commands.BlogPostCommands.Delete
{
    public class DeleteBlogPostCommandHandler : IRequestHandler<DeleteBlogPostCommandRequest, DeleteBlogPostCommandResponse>
    {
        private readonly IBlogPostWriteRepository _blogPostWriteRepository;
        private readonly IBlogPostReadRepository _blogPostReadRepository;

        public DeleteBlogPostCommandHandler(IBlogPostWriteRepository blogPostWriteRepository, IBlogPostReadRepository blogPostReadRepository)
        {
            _blogPostWriteRepository = blogPostWriteRepository;
            _blogPostReadRepository = blogPostReadRepository;
        }

        public async Task<DeleteBlogPostCommandResponse> Handle(DeleteBlogPostCommandRequest request, CancellationToken cancellationToken)
        {
            _blogPostWriteRepository.Delete(request.Id);
            _blogPostWriteRepository.SaveChanges();
            var check = _blogPostReadRepository.GetById(request.Id);
            bool success;
            if (check is null) success = true; else success = false;
            return new DeleteBlogPostCommandResponse()
            {

                IsSuccess = success
            };

        }
    }
}
