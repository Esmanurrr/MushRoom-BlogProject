﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MushRoom.Application.Features.Commands.TagCommands.Add
{
    public class AddTagCommandRequest: IRequest<AddTagCommandResponse>
    {
        public string Name { get; set; }
    }
}
