using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MushRoom.Application.Features.Commands.TagCommands.Delete
{
    public class DeleteTagCommandRequest: IRequest<DeleteTagCommandResponse>
    {
        public Guid Id { get; set; }
    }
}
