
using CommonCloud.Log;
using CommonCloud.Repository.Interface;
using MediatorUsers;
using MediatR;
using RepositoryUsers.Interface;
using RepositoryUsers.Services;
using System.Reflection;

/// <summary>
/// Mediator 
/// Middleware per i log
/// CORS
/// </summary>
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddDbContext<ApiDbContext>();
builder.Services.AddTransient<IUserRepository, UserRepository>();
builder.Services.AddTransient<ILogRepository, LogRepository>();
builder.Services.AddMediatR(typeof(MediatorEntryPoint).Assembly);
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment() || builder.Configuration.GetSection("UseSwagger").Value == "1")
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

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
