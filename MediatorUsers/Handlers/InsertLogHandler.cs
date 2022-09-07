using CommonCloud.Mediator.Commands;
using CommonCloud.Repository.Interface;
using CommonCloud.Repository.Models;
using MediatR;
using RepositoryUsers.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonCloud.Mediator.Handlers
{
    public class InsertLogHandler : IRequestHandler<InsertLogCommand, bool>
    {

        private readonly ILogRepository _repos;
        public InsertLogHandler(ILogRepository repos)
        {
            _repos = repos;
        }

        public async Task<bool> Handle(InsertLogCommand request, CancellationToken cancellationToken)
        {
            //TODO: Da migliorare mapping
            LogModel log = new LogModel()
            {
                Request = request.request,
                Response = request.response,
                Date = DateTime.Now.ToString("dd/MM/yyyy")
            };

            return await _repos.WriteLog(log);
        }
    }
}
