using MediatR;
using MushRoom.Application.Repositories.TagRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MushRoom.Application.Features.Queries.TagQueries.GetById
{
    public class GetByIdTagQueryHandler : IRequestHandler<GetByIdTagQueryRequest<Guid>, GetByIdTagQueryResponse>
    {
        private readonly ITagReadRepository _tagReadRepository;

        public GetByIdTagQueryHandler(ITagReadRepository tagReadRepository)
        {
            _tagReadRepository = tagReadRepository;
        }

        public async Task<GetByIdTagQueryResponse> Handle(GetByIdTagQueryRequest<Guid> request, CancellationToken cancellationToken)
        {
            var tag =_tagReadRepository.GetById(request.Id);
            return new() { Name = tag.Name };
        }
    }
}
