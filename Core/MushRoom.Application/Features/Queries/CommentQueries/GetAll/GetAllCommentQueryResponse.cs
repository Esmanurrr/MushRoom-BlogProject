using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MushRoom.Application.Features.Queries.CommentQueries.GetAll
{
    public class GetAllCommentQueryResponse
    {
        public string Content { get; set; }
        public Guid AppUserId { get; set; }
        public Guid BlogPostId { get; set; }
        public string UserName { get; set; }
    }
}
