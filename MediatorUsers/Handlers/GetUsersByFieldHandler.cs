using MediatorUsers.Queries;
using MediatR;
using RepositoryUsers.Models;

namespace MediatorUsers.Handlers
{
    public class GetUsersByFieldHandler : IRequestHandler<GetUsersByFieldQuery, List<UserModel>>
    {
        private readonly IMediator _mediator;
        public GetUsersByFieldHandler(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<List<UserModel>> Handle(GetUsersByFieldQuery request, CancellationToken cancellationToken)
        {
            var field = request.field;
            var result = await _mediator.Send(new GetAllUsersQuery());
            var filtered =  result.Where(x => x.Email.Contains(field) ||
                                              x.Matricola.Contains(field) ||
                                              x.Nome.Contains(field) ||
                                              x.Cognome.Contains(field) ||
                                              x.Account.Contains(field)
                                              ).ToList();
            return filtered;
        }
    }
}
