using MediatR;
using RepositoryUsers.Models;

namespace MediatorUsers.Queries
{
    public record GetUsersByEmailQuery(string email) : IRequest<List<UserModel>>;
}
