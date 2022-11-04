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
    public class GetUsersByMatricolaHandler : IRequestHandler<GetUsersByMatricolaQuery, List<UserModel>>
    {
        private readonly IUserRepository _repos;
        public GetUsersByMatricolaHandler(IUserRepository repos)
        {
            _repos = repos;
        }

        public async Task<List<UserModel>> Handle(GetUsersByMatricolaQuery request, CancellationToken cancellationToken)
        {
            return await _repos.GetUsersByMatricola(request.matricola);
        }
    }
}
