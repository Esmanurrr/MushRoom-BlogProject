using MediatR;
using MushRoom.Application.Features.Commands.BlogPostCommands.Delete;
using MushRoom.Application.Features.Commands.TagCommands.Delete;
using MushRoom.Application.Repositories.CommentRepository;
using MushRoom.Application.Repositories.TagRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MushRoom.Application.Features.Commands.CommentCommands.Delete
{
    public class DeleteCommentCommandHandler : IRequestHandler<DeleteCommentCommandRequest, DeleteCommentCommandResponse>
    {
        private readonly ICommentWriteRepository _commentWriteRepository;
        private readonly ICommentReadRepository _commentReadRepository;

        public DeleteCommentCommandHandler(ICommentWriteRepository commentWriteRepository, ICommentReadRepository commentReadRepository)
        {
            _commentWriteRepository = commentWriteRepository;
            _commentReadRepository = commentReadRepository;
        }

        public async Task<DeleteCommentCommandResponse> Handle(DeleteCommentCommandRequest request, CancellationToken cancellationToken)
        {
            // CommentId'si üzerinden yorumu bul ve sil
            _commentWriteRepository.Delete(request.CommentId);
            _commentWriteRepository.SaveChanges();
            var check = _commentReadRepository.GetById(request.CommentId);
            bool success;
            if (check is null) success = true; else success = false;
            return new DeleteCommentCommandResponse()
            {

                IsSuccess = success
            };



        }
    }
}
