namespace TaskManagement.Application.UseCases.Task.Dtos;

public class TaskDto
{
    public required string Title { get; set; }
    public required string Description { get; set; }
    public required string Status { get; set; }
}