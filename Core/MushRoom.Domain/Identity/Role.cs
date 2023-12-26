using Microsoft.AspNetCore.Identity;
using MushRoom.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MushRoom.Domain.Identity
{
    public class Role: IdentityRole<Guid>,IEntityBase<Guid>, ICreatedOn, IModifiedOn
    {
        public ICollection<User> Users { get; set; }
        public string? ModifiedByUserId { get; set; }
        public DateTimeOffset ModifiedOn { get; set; }
        public string? CreatedByUserId { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
    }
}
