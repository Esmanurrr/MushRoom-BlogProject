using MediatR;
using MushRoom.Application.Repositories.BlogPostRepository;
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

        public DeleteBlogPostCommandHandler(IBlogPostWriteRepository blogPostWriteRepository)
        {
            _blogPostWriteRepository = blogPostWriteRepository;
        }

        public async Task<DeleteBlogPostCommandResponse> Handle(DeleteBlogPostCommandRequest request, CancellationToken cancellationToken)
        {
            _blogPostWriteRepository.Delete(request.Id);
            _blogPostWriteRepository.SaveChanges();
            return new DeleteBlogPostCommandResponse();

        }
    }
}
