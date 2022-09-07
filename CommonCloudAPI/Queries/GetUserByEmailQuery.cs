using CommonCloudAPI.Models;
using MediatR;

namespace CommonCloudAPI.Queries
{
    public record GetUserByEmailQuery(string email) : IRequest<List<UserModel>>;
}
