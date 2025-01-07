using System.Reflection;

namespace TaskManagement.Application.Configuration;

public interface IApplicationConfiguration
{
    void AddAutomapperAssembly(params Assembly[] assemblies);
}