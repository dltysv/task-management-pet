﻿using TaskManagement.Domain.Abstractions;
using TaskManagement.Domain.Enums;

namespace TaskManagement.Domain.Entities;

public class TaskEntity : BaseEntity
{
    public required string Title { get; set; }
    public required string Description { get; set; }
    public TaskEntityStatus Status { get; set; }
}