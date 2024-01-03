using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MushRoom.Application.Features.Commands.CommentCommands.Add
{
    public class AddCommentCommandRequest : IRequest<AddCommentCommandResponse>
    {
        public string Content { get; set; }
        public Guid AppUserId { get; set; }
        public Guid BlogPostId { get; set; }

    }
}