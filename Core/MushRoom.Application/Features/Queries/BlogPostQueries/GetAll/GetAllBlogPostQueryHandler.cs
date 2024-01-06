using MediatR;
using MediatR.NotificationPublishers;
using Microsoft.AspNetCore.Identity;
using MushRoom.Application.Repositories.BlogPostRepository;
using MushRoom.Domain.Entities;
using MushRoom.Domain.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MushRoom.Application.Features.Queries.BlogPostQueries.GetAll
{
    public class GetAllBlogPostQueryHandler :
        IRequestHandler<GetAllBlogPostQueryRequest, List<GetAllBlogPostQueryResponse>>
    {
        private readonly IBlogPostReadRepository _blogPostReadRepository;
        private readonly UserManager<AppUser> _userManager;
        public GetAllBlogPostQueryHandler(IBlogPostReadRepository blogPostReadRepository, UserManager<AppUser> userManager)
        {
            _blogPostReadRepository = blogPostReadRepository;
            _userManager = userManager;
        }

        public async Task<List<GetAllBlogPostQueryResponse>> Handle(GetAllBlogPostQueryRequest request, CancellationToken cancellationToken)
        {
            List<BlogPost> posts = _blogPostReadRepository.GetAll();

            List<GetAllBlogPostQueryResponse> allPosts = new List<GetAllBlogPostQueryResponse>();

            foreach (var post in posts)
            {
                var appUser = await _userManager.FindByIdAsync(post.AppUserId.ToString());
                string username = $"{appUser?.FirstName} {appUser?.SurName}"; 
                GetAllBlogPostQueryResponse obj = new()
                {
                    Content = post.Content,
                    Title = post.Title,
                    Id = post.Id,
                    Tags = post.BlogPostTags,
                    //Username = post.AppUser.UserName,
                    //Username = post.AppUserId.ToString(),
                   // Username = post.AppUserId
                   Username = username,
                    
                };
                allPosts.Add(obj);

            }


            return allPosts;
        }

    }
}
