using MediatR;
using RepositoryUsers.Models;

namespace MediatorUsers.Queries
{
    public record GetAllUsersQuery() : IRequest<List<UserModel>>;
}
