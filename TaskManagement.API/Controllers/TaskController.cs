using MediatR;
using Microsoft.AspNetCore.Mvc;
using TaskManagement.Application.UseCases.Task.Commands;
using TaskManagement.Application.UseCases.Task.Queries;

namespace TaskManagement.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TaskController : ControllerBase
{
    private readonly IMediator _mediator;

    public TaskController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost("create")]
    public async Task<IActionResult> Create([FromBody] CreateTaskCommand command)
    {
        var response = await _mediator.Send(command);
        return Ok(response);
    }

    [HttpGet("get-list")]
    public async Task<IActionResult> GetList()
    {
        var response = await _mediator.Send(new GetListQuery());
        return Ok(response);
    }

    [HttpGet("get-by-id")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var response = await _mediator.Send(new GetTaskQuery { Id = id });
        return Ok(response);
    }
}