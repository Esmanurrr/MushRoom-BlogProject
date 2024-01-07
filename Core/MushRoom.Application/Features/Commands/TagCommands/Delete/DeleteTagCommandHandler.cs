using MediatR;
using MushRoom.Application.Repositories.TagRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace MushRoom.Application.Features.Commands.TagCommands.Delete
{
    public class DeleteTagCommandHandler : IRequestHandler<DeleteTagCommandRequest, DeleteTagCommandResponse>
    {
        private readonly ITagWriteRepository _tagWriteRepository;
        private readonly ITagReadRepository _tagReadRepository;

        public DeleteTagCommandHandler(ITagWriteRepository tagWriteRepository, ITagReadRepository tagReadRepository)
        {
            _tagWriteRepository = tagWriteRepository;
            _tagReadRepository = tagReadRepository;
        }

        public async Task<DeleteTagCommandResponse> Handle(DeleteTagCommandRequest request, CancellationToken cancellationToken)
        {
            _tagWriteRepository.Delete(request.Id);
            _tagWriteRepository.SaveChanges();
            var check = _tagReadRepository.GetById(request.Id);
            bool success;
            if (check is null) success = true; else success= false;
            return new DeleteTagCommandResponse()
            {

                IsSuccess = success
            };
        }
    }
}
