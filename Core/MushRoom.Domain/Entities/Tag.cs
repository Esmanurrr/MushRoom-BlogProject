using MushRoom.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MushRoom.Domain.Entities
{
    public class Tag : EntityBase<Guid>
    {
        public string ParticipantName { get; set; }
        public string ParticipantEmail { get; set; }

        public Comment Event { get; set; }
        public Guid EventId { get; set; }

        public BlogPost Participant { get; set; }
        public Guid ParticipantId { get; set; }
    }
}
