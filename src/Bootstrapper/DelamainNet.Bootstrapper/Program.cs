
using DelamainNet.Bootstrapper;
using DelamainNet.Shared.Infrastructure;
using DelamainNet.Shared.Infrastructure.Modules;

var builder = WebApplication.CreateBuilder(args);
builder.Host.ConfigureModules();
var assemblies = ModuleLoader.LoadAssemblies(builder.Configuration);

var modules =ModuleLoader.LoadModules(assemblies);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddInfrastructure(assemblies, modules);



foreach (var module in modules)
{
    module.Register(builder.Services);
}

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseInfrastructure();
foreach (var module in modules)
{
    module.Use(app);
}
app.MapControllers();

app.MapGet("/", () => "DelamainNet API!");
app.MapModuleInfo();

await app.RunAsync();

modules.Clear();
assemblies.Clear();