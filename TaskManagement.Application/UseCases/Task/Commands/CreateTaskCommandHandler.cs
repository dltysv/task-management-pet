using MediatR;
using TaskManagement.Domain.Entities;
using TaskManagement.Domain.Enums;
using TaskManagement.Domain.Repositories;

namespace TaskManagement.Application.UseCases.Task.Commands;

public class CreateTaskCommandHandler : IRequestHandler<CreateTaskCommand, bool>
{
    private readonly ITaskRepository _taskRepository;

    public CreateTaskCommandHandler(ITaskRepository taskRepository)
    {
        _taskRepository = taskRepository;
    }

    public async Task<bool> Handle(CreateTaskCommand command, CancellationToken cancellationToken)
    {
        var task = new TaskEntity
        {
            Title = command.Title,
            Description = command.Description,
            Status = TaskEntityStatus.New
        };
        
        var result = await _taskRepository.CreateTask(task);
        return result;
    }
}