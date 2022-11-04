using MediatorUsers.Queries;
using MediatR;
using RepositoryUsers.Interface;
using CommonCloud.Repository.Models;

namespace MediatorUsers.Handlers
{
    public class GetUsersByAccountHandler : IRequestHandler<GetUsersByAccountQuery, List<UserModel>>
    {
        /// <summary>
        /// Handler Get Users By Account 
        /// </summary>
        private readonly IUserRepository _repos;
        public GetUsersByAccountHandler(IUserRepository repos)
        {
            _repos = repos;
        }

        public async Task<List<UserModel>> Handle(GetUsersByAccountQuery request, CancellationToken cancellationToken)
        {
            return await _repos.GetUsersByAccount(request.account);
        }
    }
}
