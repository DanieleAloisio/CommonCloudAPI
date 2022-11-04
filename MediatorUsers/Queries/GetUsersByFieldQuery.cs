using CommonCloud.Repository.Models;
using MediatR;

namespace MediatorUsers.Queries
{
    public record GetUsersByFieldQuery(string field) : IRequest<List<AccountReteModel>>;
}
