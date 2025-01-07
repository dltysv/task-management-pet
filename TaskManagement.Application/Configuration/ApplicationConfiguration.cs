using System.Reflection;

namespace TaskManagement.Application.Configuration;

public class ApplicationConfiguration : IApplicationConfiguration
{
    private readonly List<Assembly> _assemblies;
    public Assembly[] AutomapperAssemblies => _assemblies.ToArray();

    public ApplicationConfiguration()
    {
        _assemblies = _assemblies = new List<Assembly>();
    }
    
    public void AddAutomapperAssembly(params Assembly[] assemblies)
    {
        _assemblies.AddRange(assemblies);
    }
}