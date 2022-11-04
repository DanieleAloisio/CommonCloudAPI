using CommonCloud.Repository.Models;
using MediatorUsers.Queries;
using MediatR;
using RepositoryUsers.Interface;

namespace MediatorUsers.Handlers
{
    public class GetUsersByFieldHandler : IRequestHandler<GetUsersByFieldQuery, List<AccountReteModel>>
    {
        /// <summary>
        /// Handler Get Users By Field 
        /// </summary>

        private readonly IUserRepository _repos;
        public GetUsersByFieldHandler(IUserRepository repos)
        {
            _repos = repos;
        }

        public async Task<List<AccountReteModel>> Handle(GetUsersByFieldQuery request, CancellationToken cancellationToken)
        {
            return await _repos.VW_AccountRete(request.field);
        }
    }
}
