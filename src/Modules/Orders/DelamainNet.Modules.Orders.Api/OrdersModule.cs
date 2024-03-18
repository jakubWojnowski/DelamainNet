
using DelamainNet.Shared.Abstractions.Modules;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace DelamainNet.Modules.Orders.Api
{
    internal class OrdersModule : IModule
    {
        public const string BasePath = "orders-module";     
        public string Name { get; } = "Orders";
        public string Path => BasePath;
        
        public IEnumerable<string> Policies { get; } = new[]
        {
            "orders"
        };
        
        public void Register(IServiceCollection services)
        {
        }
        
        public void Use(IApplicationBuilder app)
        {
        }
    }
}