using MediatR;
using CommonCloud.Repository.Models;

namespace MediatorUsers.Queries
{
    public record GetUsersByAccountQuery(string account) : IRequest<List<AccountReteModel>>;
}
