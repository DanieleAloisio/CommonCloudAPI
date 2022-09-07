
using CommonCloud.Log;
using CommonCloud.Repository.Interface;
using MediatorUsers;
using MediatR;
using RepositoryUsers.Interface;
using RepositoryUsers.Services;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddDbContext<ApiDbContext>();
builder.Services.AddTransient<IUserRepository, UserRepository>();
builder.Services.AddTransient<ILogRepository, LogRepository>();
builder.Services.AddMediatR(typeof(MediatorEntryPoint).Assembly);


var app = builder.Build();

//Add our new middleware to the pipeline
app.UseMiddleware<LoggingMiddleware>();


app.UseRouting();
app.UseCors(options =>
    options
        .WithMethods("POST", "PUT", "DELETE", "GET")
        .AllowAnyHeader()
);
app.MapControllers();
app.Run();
