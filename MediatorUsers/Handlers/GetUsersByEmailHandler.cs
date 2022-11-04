using MediatorUsers.Queries;
using MediatR;
using RepositoryUsers.Interface;
using CommonCloud.Repository.Models;

namespace MediatorUsers.Handlers
{
    /// <summary>
    /// Handler Get Users By Email 
    /// </summary>
    public class GetUsersByEmailHandler : IRequestHandler<GetUsersByEmailQuery, List<UserModel>>
    {
        private readonly IUserRepository _repos;
        public GetUsersByEmailHandler(IUserRepository repos)
        {
            _repos = repos;
        }

        public async Task<List<UserModel>> Handle(GetUsersByEmailQuery request, CancellationToken cancellationToken)
        {
            return await _repos.GetUsersByEmail(request.email);
        }
    }
}
