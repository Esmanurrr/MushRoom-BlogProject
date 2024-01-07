using MediatR;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MushRoom.Application.Features.Commands.BlogPostCommands.Edit
{
    public class EditBlogPostCommandRequest<TKey> : IRequest<EditBlogPostCommandResponse>
    {
        public TKey Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
