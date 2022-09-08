using MediatR;
using RepositoryUsers.Models;

namespace MediatorUsers.Queries
{
    public record GetUsersByFieldQuery(string field) : IRequest<List<UserModel>>;
}
