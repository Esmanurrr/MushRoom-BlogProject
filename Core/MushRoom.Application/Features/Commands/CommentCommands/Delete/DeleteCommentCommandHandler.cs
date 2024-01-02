using MediatR;
using MushRoom.Application.Features.Commands.BlogPostCommands.Delete;
using MushRoom.Application.Repositories.CommentRepository;
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

        public DeleteCommentCommandHandler(ICommentWriteRepository commentWriteRepository)
        {
            _commentWriteRepository = commentWriteRepository;
        }

        public async Task<DeleteCommentCommandResponse> Handle(DeleteCommentCommandRequest request, CancellationToken cancellationToken)
        {
            // CommentId'si üzerinden yorumu bul ve sil
            _commentWriteRepository.Delete(request.CommentId);
            _commentWriteRepository.SaveChanges();
            var response = new DeleteCommentCommandResponse
            {
                IsSuccess = true,
                DeletedCommentId = request.CommentId // Silinen yorumun kimliği veya diğer bilgiler...
            };

            return response;



        }
    }
}
