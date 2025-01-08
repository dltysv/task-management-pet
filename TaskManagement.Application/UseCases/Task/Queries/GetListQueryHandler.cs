using AutoMapper;
using MediatR;
using TaskManagement.Application.UseCases.Task.Dtos;
using TaskManagement.Domain.Repositories;

namespace TaskManagement.Application.UseCases.Task.Queries;

public class GetListQueryHandler : IRequestHandler<GetListQuery, List<TaskDto>>
{
    private readonly ITaskRepository _taskRepository;
    private readonly IMapper _mapper;

    public GetListQueryHandler(ITaskRepository taskRepository, IMapper mapper)
    {
        _taskRepository = taskRepository;
        _mapper = mapper;
    }

    public async Task<List<TaskDto>> Handle(GetListQuery request, CancellationToken cancellationToken)
    {
        var tasks = await _taskRepository.GetAllTasks();
        var taskDtoList = _mapper.Map<List<TaskDto>>(tasks);
        return taskDtoList;
    }
}