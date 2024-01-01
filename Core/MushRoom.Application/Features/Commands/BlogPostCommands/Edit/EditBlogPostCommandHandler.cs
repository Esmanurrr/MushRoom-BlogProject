using MediatR;
using MushRoom.Application.Features.Queries.BlogPostQueries.GetById;
using MushRoom.Application.Repositories;
using MushRoom.Application.Repositories.BlogPostRepository;
using MushRoom.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MushRoom.Application.Features.Commands.BlogPostCommands.Edit
{
    public class EditBlogPostCommandHandler : IRequestHandler<EditBlogPostCommandRequest<Guid>, EditBlogPostCommandResponse>
    {
        private readonly IBlogPostWriteRepository _writeRepository;
        private readonly IBlogPostReadRepository  _readRepository;

        public EditBlogPostCommandHandler(IBlogPostWriteRepository writeRepository, IBlogPostReadRepository readRepository)
        {
            _writeRepository = writeRepository;
            _readRepository = readRepository;
        }

        public async Task<EditBlogPostCommandResponse> Handle(Edit.EditBlogPostCommandRequest<Guid> request, CancellationToken cancellationToken)
        {
            //ETicaretAPI.Domain.Entities.Product p = await _productReadRepository.GetByIdAsync(request.Id);
            //p.Name = request.Name;
            //p.Stock = request.Stock;
            //p.Price = request.Price;
            //await _productWriteRepository.SaveAsync();
            //_logger.LogInformation("Product Güncellendi");
            //return new();

            BlogPost post = _readRepository.GetById(request.Id);
            post.Title = request.Title;
            post.Content = request.Content;
            _writeRepository.SaveChanges();
            return new();


        }
    }
}
