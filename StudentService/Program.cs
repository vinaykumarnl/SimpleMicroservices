using Microsoft.EntityFrameworkCore;
using StudentService.Database;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<StudentdbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("conn1")));
var app = builder.Build();


// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
