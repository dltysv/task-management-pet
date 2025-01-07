using AutoMapper;
using TaskManagement.Application.UseCases.Task.Dtos;
using TaskManagement.Domain.Entities;

namespace TaskManagement.Application.Mapping;

public class TaskProfile : Profile
{
    public TaskProfile()
    {
        CreateMap<TaskEntity, TaskDto>();
    }
}