using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MushRoom.Application.Features.Commands.BlogPostCommands.Add;
using MushRoom.Application.Features.Commands.BlogPostCommands.Delete;
using MushRoom.Application.Features.Commands.BlogPostCommands.Edit;
using MushRoom.Application.Features.Queries.BlogPostQueries.GetAll;
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
        public async Task<IActionResult> GetAll([FromQuery]  GetAllBlogPostQueryRequest request)
        {
            List<GetAllBlogPostQueryResponse> allPosts = await _mediator.Send(request);
            return Ok(allPosts);

        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Add(AddBlogPostCommandRequest addBlogPostCommandRequest)
        {
            var response = await _mediator.Send(addBlogPostCommandRequest);
            return Ok(response);

        }

        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> Delete(DeleteBlogPostCommandRequest request)
        {
            return Ok(await _mediator.Send(request));
        }

        [HttpPut("{id:guid}")]
        public async Task<IActionResult> Edit([FromBody] EditBlogPostCommandRequest<Guid> request)
        {
            await _mediator.Send(request);
            return Ok();
        }
    }
}
