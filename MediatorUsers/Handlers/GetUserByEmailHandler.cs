using MediatorUsers.Queries;
using MediatR;
using RepositoryUsers.Models;

namespace MediatorUsers.Handlers
{
    public class GetUserByEmailHandler : IRequestHandler<GetUserByEmailQuery, List<UserModel>>
    {
        private readonly IMediator _mediator;
        public GetUserByEmailHandler(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<List<UserModel>> Handle(GetUserByEmailQuery request, CancellationToken cancellationToken)
        {
            var result = await _mediator.Send(new GetAllUsersQuery());
            var filtered =  result.Where(x => x.Email.Contains(request.email)).ToList();
            return filtered;
        }
    }
}
