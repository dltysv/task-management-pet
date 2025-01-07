using AutoMapper;
using MediatR;
using TaskManagement.Application.UseCases.Task.Dtos;
using TaskManagement.Domain.Repositories;

namespace TaskManagement.Application.UseCases.Task.Queries;

public class GetTaskQueryHandler : IRequestHandler<GetTaskQuery, TaskDto?>
{
    private readonly ITaskRepository _taskRepository;
    private readonly IMapper _mapper;

    public GetTaskQueryHandler(ITaskRepository taskRepository, IMapper mapper)
    {
        _taskRepository = taskRepository;
        _mapper = mapper;
    }

    public async Task<TaskDto?> Handle(GetTaskQuery request, CancellationToken cancellationToken)
    {
        var task = await _taskRepository.GetTaskById(request.Id);
        var taskDto = _mapper.Map<TaskDto>(task);
        return taskDto;
    }
}