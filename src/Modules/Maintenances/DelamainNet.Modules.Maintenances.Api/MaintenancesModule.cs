using DelamainNet.Shared.Abstractions.Modules;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace DelamainNet.Modules.Maintenances.Api
{
    internal class MaintenancesModule : IModule
    {
        public const string BasePath = "maintenances-module";     
        public string Name { get; } = "Maintenances";
        public string Path => BasePath;
        
        public IEnumerable<string> Policies { get; } = new[]
        {
            "maintenances"
        };
        
        public void Register(IServiceCollection services)
        {
        }
        
        public void Use(IApplicationBuilder app)
        {
        }
    }
}