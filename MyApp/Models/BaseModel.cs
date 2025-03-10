﻿namespace MyApp.models;

public abstract class BaseModel
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public bool Deleted { get; set; }
    public DateTime CreatedAt { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public Guid? UpdatedBy { get; set; }
}