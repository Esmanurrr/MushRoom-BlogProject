using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MushRoom.Application.Features.Commands.TagCommands.Edit
{
    public class EditTagCommandRequest<TKey>:IRequest<EditTagCommandResponse>
    {
        public TKey Id { get; set; }
        public string Name { get; set; }
    }
}
