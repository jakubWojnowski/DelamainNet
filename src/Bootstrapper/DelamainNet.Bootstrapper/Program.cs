using DelamainNet.Bootstrapper;
using DelamainNet.Shared.Infrastructure;
using DelamainNet.Shared.Infrastructure.Modules;

var builder = WebApplication.CreateBuilder(args);

var assemblies = ModuleLoader.LoadAssemblies(builder.Configuration);
var modules = ModuleLoader.LoadModules(assemblies);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddInfrastructure(assemblies, modules);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.UseInfrastructure();
foreach (var module in modules)
{
    module.Use(app);
}
app.MapControllers();

app.MapGet("/", () => "Delamain API!");
app.MapModuleInfo();

await app.RunAsync();

modules.Clear();
assemblies.Clear();

