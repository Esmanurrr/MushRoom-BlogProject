using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MushRoom.Application.Features.Commands.CommentCommands.Delete
{
    public class DeleteCommentCommandResponse
    {
        public bool IsSuccess { get; set; }
        public Guid DeletedCommentId { get; set; }
    }
}
