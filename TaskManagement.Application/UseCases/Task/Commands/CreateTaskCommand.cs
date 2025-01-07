using MediatR;

namespace TaskManagement.Application.UseCases.Task.Commands;

public class CreateTaskCommand : IRequest<bool>
{
    public required string Title { get; set; }
    public required string Description { get; set; }
}