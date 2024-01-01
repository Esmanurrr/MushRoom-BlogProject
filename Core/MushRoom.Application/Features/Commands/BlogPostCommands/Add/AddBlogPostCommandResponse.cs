using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MushRoom.Application.Features.Commands.BlogPostCommands.Add
{
    public class AddBlogPostCommandResponse
    {
        public bool IsSuccess { get; set; }
    }
}
