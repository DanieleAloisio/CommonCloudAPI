using MediatR;
using RepositoryUsers.Models;

namespace MediatorUsers.Queries
{
    public record GetUsersByAccountQuery(string account) : IRequest<List<UserModel>>;
}
