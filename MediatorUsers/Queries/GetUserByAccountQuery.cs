using MediatR;
using RepositoryUsers.Models;

namespace MediatorUsers.Queries
{
    public record GetUserByAccountQuery(string account) : IRequest<List<UserModel>>;
}
