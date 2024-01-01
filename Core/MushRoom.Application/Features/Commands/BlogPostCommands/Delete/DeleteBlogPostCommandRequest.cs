using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MushRoom.Application.Features.Commands.BlogPostCommands.Delete
{
    public class DeleteBlogPostCommandRequest : IRequest<DeleteBlogPostCommandResponse>
    {
        public Guid Id { get; set; }
    }
}
