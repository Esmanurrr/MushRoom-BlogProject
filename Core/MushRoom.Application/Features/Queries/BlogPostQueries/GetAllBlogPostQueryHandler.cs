using MediatR;
using MediatR.NotificationPublishers;
using MushRoom.Application.Repositories.BlogPostRepository;
using MushRoom.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MushRoom.Application.Features.Queries.BlogPostQueries
{
    public class GetAllBlogPostQueryHandler : 
        IRequestHandler<GetAllBlogPostQueryRequest, List<GetAllBlogPostQueryResponse>>
    {
        private readonly IBlogPostReadRepository _blogPostReadRepository;

        public GetAllBlogPostQueryHandler(IBlogPostReadRepository blogPostReadRepository)
        {
            _blogPostReadRepository = blogPostReadRepository;
        }

        public async Task<List<GetAllBlogPostQueryResponse>> Handle(GetAllBlogPostQueryRequest request, CancellationToken cancellationToken)
        {
            List<BlogPost> posts = _blogPostReadRepository.GetAll();

            List<GetAllBlogPostQueryResponse> allPosts= new List<GetAllBlogPostQueryResponse>();

            foreach (var post in posts)
            {
                GetAllBlogPostQueryResponse obj = new()
                {
                    Content = post.Content,
                    Title = post.Title,
                    Id = post.Id,
                    Tags = post.BlogPostTags,
                    Username = post.User.UserName
                };
                allPosts.Add(obj);

            }


            return allPosts;
        }

    }
}
