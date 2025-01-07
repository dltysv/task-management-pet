using MediatR;
using TaskManagement.Application.UseCases.Task.Dtos;

namespace TaskManagement.Application.UseCases.Task.Queries;

public record GetListQuery : IRequest<List<TaskDto>>;