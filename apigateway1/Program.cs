using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
/*builder.Configuration.SetBasePath(builder.Environment.ContentRootPath).AddJsonFile("ocelot.json", optional:false,reloadOnChange:true).AddEnvironmentVariables();
builder.Services.AddOcelot(builder.Configuration);*/
builder.Configuration.AddJsonFile("ocelot.json");
var app = builder.Build();
await app.UseOcelot();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    
}

app.UseAuthorization();

app.MapControllers();

app.Run();
