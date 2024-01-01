using MushRoom.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MushRoom.Application.Features.Queries.BlogPostQueries.GetAll
{
    public class GetAllBlogPostQueryResponse
    {
        //List<BlogPost> blogPosts;
        //public BlogPost post {  get; set; }
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Username { get; set; }
        public ICollection<BlogPostTag> Tags { get; set; }
    }
}
