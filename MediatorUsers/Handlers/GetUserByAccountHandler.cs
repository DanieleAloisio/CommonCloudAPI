using MediatorUsers.Queries;
using MediatR;
using RepositoryUsers.Models;

namespace MediatorUsers.Handlers
{
    public class GetUserByAccountHandler : IRequestHandler<GetUserByAccountQuery, List<UserModel>>
    {
        private readonly IMediator _mediator;
        public GetUserByAccountHandler(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<List<UserModel>> Handle(GetUserByAccountQuery request, CancellationToken cancellationToken)
        {
            var result = await _mediator.Send(new GetAllUsersQuery());
            var filtered = result.Where(x => x.Account.Contains(request.account)).ToList();
            return filtered;
        }
    }
}
