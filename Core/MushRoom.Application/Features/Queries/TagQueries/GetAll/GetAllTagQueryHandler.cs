using MediatR;
using MushRoom.Application.Repositories.TagRepository;
using MushRoom.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MushRoom.Application.Features.Queries.TagQueries.GetAll
{
    public class GetAllTagQueryHandler : 
        IRequestHandler<GetAllTagQueryRequest, List<GetAllTagQueryResponse>>
    {
        private readonly ITagReadRepository _tagReadRepository;

        public GetAllTagQueryHandler(ITagReadRepository tagReadRepository)
        {
            _tagReadRepository = tagReadRepository;
        }

        public async Task<List<GetAllTagQueryResponse>> Handle(GetAllTagQueryRequest request, CancellationToken cancellationToken)
        {
            List<Tag> tags = _tagReadRepository.GetAll();
            List<GetAllTagQueryResponse> allTags= new List<GetAllTagQueryResponse>();

            foreach (Tag tag in tags)
            {
                GetAllTagQueryResponse obj = new()
                {
                    Id = tag.Id,
                    Name = tag.Name,
                };
                allTags.Add(obj);

            }
            return allTags;
        }
    }
}
