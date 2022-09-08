using MediatorUsers.Queries;
using MediatR;
using RepositoryUsers.Interface;
using RepositoryUsers.Models;

namespace MediatorUsers.Handlers
{
    public class GetUsersByFieldHandler : IRequestHandler<GetUsersByFieldQuery, List<UserModel>>
    {
        /// <summary>
        /// Handler Get Users By Field 
        /// </summary>

        private readonly IUserRepository _repos;
        public GetUsersByFieldHandler(IUserRepository repos)
        {
            _repos = repos;
        }

        public async Task<List<UserModel>> Handle(GetUsersByFieldQuery request, CancellationToken cancellationToken)
        {
            return await _repos.GetUsersByFreeSearch(request.field);
        }
    }
}
