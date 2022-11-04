using MediatorUsers.Queries;
using MediatR;
using RepositoryUsers.Interface;
using CommonCloud.Repository.Models;

namespace MediatorUsers.Handlers
{
    public class GetUsersByAccountHandler : IRequestHandler<GetUsersByAccountQuery, List<AccountReteModel>>
    {
        /// <summary>
        /// Handler Get Users By Account 
        /// </summary>
        private readonly IUserRepository _repos;
        public GetUsersByAccountHandler(IUserRepository repos)
        {
            _repos = repos;
        }

        public async Task<List<AccountReteModel>> Handle(GetUsersByAccountQuery request, CancellationToken cancellationToken)
        {
            return await _repos.GetUsersByAccount(request.account);
        }
    }
}
