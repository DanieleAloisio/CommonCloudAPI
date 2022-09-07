using MediatR;
using RepositoryUsers.Models;

namespace MediatorUsers.Queries
{
    public record GetUserByEmailQuery(string email) : IRequest<List<UserModel>>;
}
