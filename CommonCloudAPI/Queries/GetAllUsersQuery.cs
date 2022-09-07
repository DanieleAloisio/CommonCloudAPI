using CommonCloudAPI.Models;
using MediatR;

namespace CommonCloudAPI.Queries
{
    public record GetAllUsersQuery() : IRequest<List<UserModel>>;
}
