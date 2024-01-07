using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MushRoom.Application.Features.Queries.BlogPostQueries.GetById
{
    public class GetByIdBlogPostQueryResponse
    {
        public string Title { get; set; }
        public string Content { get; set; }

        // public AppUser AppUser { get; set; } user eklendiğinde o an aktif olan user'ı atarız

    }
}
