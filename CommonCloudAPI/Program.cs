
using MediatorUsers;
using MediatR;
using RepositoryUsers.Interface;
using RepositoryUsers.Services;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddDbContext<ApiDbContext>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddMediatR(typeof(MediatorEntryPoint).Assembly);



var app = builder.Build();

app.UseRouting();
app.UseCors(options =>
    options
        .WithMethods("POST", "PUT", "DELETE", "GET")
        .AllowAnyHeader()
);
app.MapControllers();
app.Run();
