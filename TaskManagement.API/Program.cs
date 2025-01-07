using System.Reflection;
using Microsoft.EntityFrameworkCore;
using TaskManagement.Application;
using TaskManagement.Application.Configuration;
using TaskManagement.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddInfrastructure(builder.Configuration);

var applicationConfiguration = new ApplicationConfiguration();
builder.Services.AddApplication(applicationConfiguration, cfg =>
{
    cfg.AddAutomapperAssembly(typeof(TaskManagement.Application.Mapping.TaskProfile).Assembly);
});

builder.Services.AddAutoMapper(x =>
{ 
    x.AddGlobalIgnore("IsDeleted");
}, applicationConfiguration.AutomapperAssemblies);


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
