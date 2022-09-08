using MediatR;
using RepositoryUsers.Models;

namespace MediatorUsers.Queries
{
    public record GetUsersByMatricolaQuery(string matricola) : IRequest<List<UserModel>>;
}
