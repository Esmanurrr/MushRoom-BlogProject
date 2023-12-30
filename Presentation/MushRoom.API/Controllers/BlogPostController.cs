using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MushRoom.Application.Features.Commands.BlogPostCommands.Add;
using MushRoom.Application.Repositories.BlogPostRepository;
using MushRoom.Domain.Entities;
using MushRoom.Persistence.Repositories.BlogPostRepository;

namespace MushRoom.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogPostController : ControllerBase
    {
        private readonly IBlogPostReadRepository _blogPostReadRepository;
        private readonly IMediator _mediator;

        public BlogPostController(IBlogPostReadRepository blogPostReadRepository, IMediator mediator)
        {
            _blogPostReadRepository = blogPostReadRepository;
 
            _mediator = mediator;
        }
        [HttpGet("[action]")]
        public List<BlogPost> GetAll()
        {
            return _blogPostReadRepository.GetAll();

        }

        [HttpGet("[action]")]
        public async Task<IActionResult> Add(AddBlogPostCommandRequest addBlogPostCommandRequest)
        {
            var response = await _mediator.Send(addBlogPostCommandRequest);
            return Ok(response);

        }
    }
}
