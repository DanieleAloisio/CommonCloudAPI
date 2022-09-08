using MediatR;
using RepositoryUsers.Models;

namespace MediatorUsers.Queries
{
    public record GetUserByMatricolaQuery(string matricola) : IRequest<List<UserModel>>;
}
