
using CommonCloud.Repository.Models;
using MediatorUsers.Queries;
using MediatR;
using RepositoryUsers.Interface;


namespace MediatorUsers.Handlers
{
    /// <summary>
    /// Handler restituisce tutti gli user
    /// </summary>
    public class GetAllUsersHandler : IRequestHandler<GetAllUsersQuery, List<AccountReteModel>>
    {
        private readonly IUserRepository _repository;
        public GetAllUsersHandler(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<AccountReteModel>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
        {
            return await _repository.GetAllUsers();
        }
    }
}
