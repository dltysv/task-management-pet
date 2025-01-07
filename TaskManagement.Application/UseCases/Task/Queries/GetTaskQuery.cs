using MediatR;
using TaskManagement.Application.UseCases.Task.Dtos;

namespace TaskManagement.Application.UseCases.Task.Queries;

public record GetTaskQuery : IRequest<TaskDto?>
{
    public Guid Id { get; init; }
}