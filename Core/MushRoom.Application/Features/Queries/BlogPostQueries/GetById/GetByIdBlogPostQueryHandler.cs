using MediatR;
using MushRoom.Application.Repositories.BlogPostRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MushRoom.Application.Features.Queries.BlogPostQueries.GetById
{
    public class GetByIdBlogPostQueryHandler : IRequestHandler<GetByIdBlogPostQueryRequest<Guid>, GetByIdBlogPostQueryResponse>
    {
        private readonly IBlogPostReadRepository _readRepository;

        public GetByIdBlogPostQueryHandler(IBlogPostReadRepository readRepository)
        {
            _readRepository = readRepository;
        }

        public async Task<GetByIdBlogPostQueryResponse> Handle(GetByIdBlogPostQueryRequest<Guid> request, CancellationToken cancellationToken)
        {
            //var product = await _productReadRepository.GetByIdAsync(request.Id, false);
            //return new()
            //{
            //    Name = product.Name,
            //    Price = product.Price,
            //    Stock = product.Stock
            //};

            var post = _readRepository.GetById(request.Id);
            return new()
            {
                Title = post.Title,
                Content = post.Content
            };
        }
    }
}
