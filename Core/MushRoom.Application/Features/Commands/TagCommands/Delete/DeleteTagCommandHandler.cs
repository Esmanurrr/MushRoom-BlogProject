using MediatR;
using MushRoom.Application.Repositories.TagRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MushRoom.Application.Features.Commands.TagCommands.Delete
{
    public class DeleteTagCommandHandler : IRequestHandler<DeleteTagCommandRequest, DeleteTagCommandResponse>
    {
        private readonly ITagWriteRepository _tagWriteRepository;

        public DeleteTagCommandHandler(ITagWriteRepository tagWriteRepository)
        {
            _tagWriteRepository = tagWriteRepository;
        }

        public async Task<DeleteTagCommandResponse> Handle(DeleteTagCommandRequest request, CancellationToken cancellationToken)
        {
            _tagWriteRepository.Delete(request.Id);
            _tagWriteRepository.SaveChanges();
            return new DeleteTagCommandResponse();
        }
    }
}
