using MediatorUsers.Queries;
using MediatR;
using RepositoryUsers.Models;

namespace MediatorUsers.Handlers
{
    public class GetUserByMatricolaHandler : IRequestHandler<GetUserByMatricolaQuery, List<UserModel>>
    {
        private readonly IMediator _mediator;
        public GetUserByMatricolaHandler(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<List<UserModel>> Handle(GetUserByMatricolaQuery request, CancellationToken cancellationToken)
        {
            var result = await _mediator.Send(new GetAllUsersQuery());
            var filtered =  result.Where(x => x.Matricola.Contains(request.matricola)).ToList();
            return filtered;
        }
    }
}
