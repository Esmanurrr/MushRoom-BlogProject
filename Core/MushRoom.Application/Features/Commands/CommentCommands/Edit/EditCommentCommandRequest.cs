using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MushRoom.Application.Features.Commands.CommentCommands.Edit
{
    public class EditCommentCommandRequest<TKey> : IRequest<EditCommentCommandResponse>
    {
        public TKey CommentId { get; set; }
        public string NewContent { get; set; }
    }
}
