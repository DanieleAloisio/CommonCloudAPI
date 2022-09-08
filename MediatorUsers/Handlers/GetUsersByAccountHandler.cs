using MediatorUsers.Queries;
using MediatR;
using RepositoryUsers.Models;

namespace MediatorUsers.Handlers
{
    public class GetUsersByAccountHandler : IRequestHandler<GetUsersByAccountQuery, List<UserModel>>
    {
        private readonly IMediator _mediator;
        public GetUsersByAccountHandler(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<List<UserModel>> Handle(GetUsersByAccountQuery request, CancellationToken cancellationToken)
        {
            var result = await _mediator.Send(new GetAllUsersQuery());
            var filtered = result.Where(x => x.Account.Contains(request.account)).ToList();
            return filtered;
        }
    }
}
