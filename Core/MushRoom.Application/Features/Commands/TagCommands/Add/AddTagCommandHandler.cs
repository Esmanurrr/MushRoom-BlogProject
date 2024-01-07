using MediatR;
using MushRoom.Application.Features.Commands.BlogPostCommands.Add;
using MushRoom.Application.Features.Commands.CommentCommands.Add;
using MushRoom.Application.Repositories.TagRepository;
using MushRoom.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MushRoom.Application.Features.Commands.TagCommands.Add
{
    public class AddTagCommandHandler : IRequestHandler<AddTagCommandRequest, AddTagCommandResponse>
    {        
        private readonly ITagWriteRepository _writeRepository;

        public AddTagCommandHandler(ITagWriteRepository writeRepository)
        {
            _writeRepository = writeRepository;
        }

        public async  Task<AddTagCommandResponse> Handle(AddTagCommandRequest request, CancellationToken cancellationToken)
        {
            Tag tag = new Tag()
            {
                Name = request.Name,
                Id= Guid.NewGuid(),
                CreatedByUserId = "zbd",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn= DateTime.UtcNow,
                IsDeleted=false

            };
            _writeRepository.Add(tag);
            _writeRepository.SaveChanges();

            var response = new AddTagCommandResponse
            {
                IsSuccess = tag.Id != Guid.Empty
            };

            return response;
        }
    }
}
