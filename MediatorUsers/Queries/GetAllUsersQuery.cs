using MediatR;
using CommonCloud.Repository.Models;

namespace MediatorUsers.Queries
{
    public record GetAllUsersQuery() : IRequest<List<AccountReteModel>>;
}
