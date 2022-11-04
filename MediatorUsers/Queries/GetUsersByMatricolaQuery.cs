using MediatR;
using CommonCloud.Repository.Models;

namespace MediatorUsers.Queries
{
    public record GetUsersByMatricolaQuery(string matricola) : IRequest<List<UserModel>>;
}
