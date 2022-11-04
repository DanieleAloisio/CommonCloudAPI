using MediatorUsers.Queries;
using MediatR;
using RepositoryUsers.Interface;
using CommonCloud.Repository.Models;

namespace MediatorUsers.Handlers
{
    /// <summary>
    /// Handler Get Users By Matricola 
    /// </summary>
    /// 
    public class GetUsersByMatricolaHandler : IRequestHandler<GetUsersByMatricolaQuery, List<AccountReteModel>>
    {
        private readonly IUserRepository _repos;
        public GetUsersByMatricolaHandler(IUserRepository repos)
        {
            _repos = repos;
        }

        public async Task<List<AccountReteModel>> Handle(GetUsersByMatricolaQuery request, CancellationToken cancellationToken)
        {
            return await _repos.GetUsersByMatricola(request.matricola);
        }
    }
}
