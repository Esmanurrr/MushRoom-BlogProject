using MediatR;
using MushRoom.Application.Repositories.TagRepository;
using MushRoom.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MushRoom.Application.Features.Commands.TagCommands.Edit
{
    public class EditTagCommandHandler : IRequestHandler<EditTagCommandRequest<Guid>, EditTagCommandResponse>
    {
        private readonly ITagReadRepository _tagReadRepository;
        private readonly ITagWriteRepository _tagWriteRepository;

        public EditTagCommandHandler(ITagReadRepository tagReadRepository,ITagWriteRepository tagWriteRepository)
        {
            _tagReadRepository = tagReadRepository;
            _tagWriteRepository = tagWriteRepository;
        }

        public async Task<EditTagCommandResponse> Handle(EditTagCommandRequest<Guid> request, CancellationToken cancellationToken)
        {
            Tag tag = _tagReadRepository.GetById(request.Id);
            if(tag is not null)
            {
                tag.Name = request.Name;
                _tagWriteRepository.SaveChanges();

                return new EditTagCommandResponse { IsSuccess = true };
            }
            return new EditTagCommandResponse { IsSuccess = false };
        }
    }
}
