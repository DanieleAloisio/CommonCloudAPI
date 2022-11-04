using MediatR;
using CommonCloud.Repository.Models;

namespace MediatorUsers.Queries
{
    public record GetUsersByEmailQuery(string email) : IRequest<List<AccountReteModel>>;
}
