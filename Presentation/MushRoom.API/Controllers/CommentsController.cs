using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MushRoom.Application.Features.Commands.CommentCommands.Add;
using MushRoom.Application.Features.Commands.CommentCommands.Delete;
using MushRoom.Application.Features.Commands.CommentCommands.Edit;
using MushRoom.Application.Features.Queries.CommentQueries.GetAll;
using MushRoom.Application.Features.Queries.CommentQueries.GetById;
using MushRoom.Application.Repositories.CommentRepository;

namespace MushRoom.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class CommentsController : ControllerBase
    {
        private readonly ICommentReadRepository _commentReadRepository;
        private readonly IMediator _mediator;

        public CommentsController(ICommentReadRepository commentReadRepository, IMediator mediator)
        {
          _commentReadRepository = commentReadRepository;

            _mediator = mediator;
        }


        [HttpGet("[action]")]
        public async Task<IActionResult> GetAll([FromQuery] GetAllCommentQueryRequest request)
        {
            List<GetAllCommentQueryResponse> allComment = await _mediator.Send(request);
            return Ok(allComment);

        }
        [HttpGet("{Id}")]
        public async Task<IActionResult> GetById([FromRoute] GetByIdCommentQueryRequest<Guid> getByIdCommentQueryRequest)
        {
            return Ok(await _mediator.Send(getByIdCommentQueryRequest));
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Add(AddCommentCommandRequest addCommentCommandRequest)
        {
            var response = await _mediator.Send(addCommentCommandRequest);
            return Ok(response);

        }

        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> Delete(DeleteCommentCommandRequest request)
        {
            return Ok(await _mediator.Send(request));
        }

        [HttpPut("{id:guid}")]
        public async Task<IActionResult> Edit([FromBody] EditCommentCommandRequest<Guid> request)
        {
            
            return Ok(await _mediator.Send(request));
        }


    }
}
