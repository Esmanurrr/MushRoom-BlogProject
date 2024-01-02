using MediatR;
using MushRoom.Application.Features.Commands.BlogPostCommands.Delete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MushRoom.Application.Features.Commands.CommentCommands.Delete
{
    public class DeleteCommentCommandRequest : IRequest<DeleteCommentCommandResponse>
    {
        public Guid CommentId { get; set; }
    }
}
