﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MediatR;

using MushRoom.Application.Features.Queries.TagQueries.GetAll;
using MushRoom.Application.Features.Commands.TagCommands.Add;
using MushRoom.Application.Features.Commands.TagCommands.Delete;
using MushRoom.Application.Features.Commands.TagCommands.Edit;

namespace MushRoom.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TagsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TagsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetAll([FromQuery] GetAllTagQueryRequest request)
        {
            List<GetAllTagQueryResponse> allPosts = await _mediator.Send(request);
            return Ok(allPosts);

        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Add(AddTagCommandRequest addBlogPostCommandRequest)
        {
            var response = await _mediator.Send(addBlogPostCommandRequest);
            return Ok(response);

        }

        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> Delete(DeleteTagCommandRequest request)
        {
            return Ok(await _mediator.Send(request));
        }

        [HttpPut("{id:guid}")]
        public async Task<IActionResult> Edit([FromBody] EditTagCommandRequest<Guid> request)
        {
            await _mediator.Send(request);
            return Ok();
        }
    }
}
