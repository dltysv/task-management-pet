using Microsoft.EntityFrameworkCore;
using TaskManagement.Domain.Entities;
using TaskManagement.Domain.Repositories;
using TaskManagement.Infrastructure.Persistence;

namespace TaskManagement.Infrastructure.Repositories;

public class TaskRepository : ITaskRepository
{
    private readonly TaskManagementDbContext _dbContext;

    public TaskRepository(TaskManagementDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<bool> CreateTask(TaskEntity task)
    {
        await _dbContext.Tasks.AddAsync(task);
        await _dbContext.SaveChangesAsync();
        return true;
    }

    public async Task<List<TaskEntity>> GetAllTasks()
    {
        var tasks = await _dbContext.Tasks.ToListAsync();
        return tasks;
    }

    public async Task<TaskEntity?> GetTaskById(Guid id)
    {
        var task = await _dbContext.Tasks.FindAsync(id);
        return task;
    }
}