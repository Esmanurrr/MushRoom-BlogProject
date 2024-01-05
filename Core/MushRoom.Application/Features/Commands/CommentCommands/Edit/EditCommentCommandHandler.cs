using MediatR;
using MushRoom.Application.Features.Commands.BlogPostCommands.Edit;
using MushRoom.Application.Repositories;
using MushRoom.Application.Repositories.BlogPostRepository;
using MushRoom.Application.Repositories.CommentRepository;
using MushRoom.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MushRoom.Application.Features.Commands.CommentCommands.Edit
{
    public class EditCommentCommandHandler : IRequestHandler<EditCommentCommandRequest<Guid>, EditCommentCommandResponse>
    {
        private readonly ICommentWriteRepository _commentWriteRepository;
        private readonly ICommentReadRepository _commentReadRepository;
        public EditCommentCommandHandler(ICommentWriteRepository commentWriteRepository, ICommentReadRepository commentReadRepository)
        {
          _commentReadRepository = commentReadRepository;
          _commentWriteRepository = commentWriteRepository;
        }
        public async Task<EditCommentCommandResponse> Handle(EditCommentCommandRequest<Guid> request, CancellationToken cancellationToken)
        {
     
            Comment comment =  _commentReadRepository.GetById(request.CommentId);

            if (comment != null)
            {
                comment.Content = request.NewContent;
                // Diğer özelliklerin güncellenmesi

                //_commentWriteRepository.Edit(comment.Id);
                _commentWriteRepository.SaveChanges();

                return new EditCommentCommandResponse { IsSuccess = true };
            }

            return new EditCommentCommandResponse { IsSuccess = false };


        }
    }
}
