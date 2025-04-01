using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddAutoMapper(Assembly.GetCallingAssembly());

var app = builder.Build();

app.MapControllers();

app.Run();
