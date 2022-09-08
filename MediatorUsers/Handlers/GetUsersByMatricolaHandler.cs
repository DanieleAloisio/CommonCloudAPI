using MediatorUsers.Queries;
using MediatR;
using RepositoryUsers.Models;

namespace MediatorUsers.Handlers
{
    public class GetUsersByMatricolaHandler : IRequestHandler<GetUsersByMatricolaQuery, List<UserModel>>
    {
        private readonly IMediator _mediator;
        public GetUsersByMatricolaHandler(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<List<UserModel>> Handle(GetUsersByMatricolaQuery request, CancellationToken cancellationToken)
        {
            var result = await _mediator.Send(new GetAllUsersQuery());
            var filtered =  result.Where(x => x.Matricola.Contains(request.matricola)).ToList();
            return filtered;
        }
    }
}
