using CommonCloudAPI.Interface;
using CommonCloudAPI.Models;
using CommonCloudAPI.Queries;
using CommonCloudAPI.Services;
using MediatR;

namespace CommonCloudAPI.Handlers
{
    public class GetAllUsersHandler : IRequestHandler<GetAllUsersQuery, List<UserModel>>
    {
        private readonly IUserRepository _repository;
        public GetAllUsersHandler(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<UserModel>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
        {
            return await _repository.GetAllUsers();
        }
    }
}
