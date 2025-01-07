using TaskManagement.Domain.Entities;

namespace TaskManagement.Domain.Repositories;

public interface ITaskRepository
{
    Task<bool> CreateTask(TaskEntity task);
    Task<List<TaskEntity>> GetAllTasks();
    Task<TaskEntity?> GetTaskById(Guid id);
}