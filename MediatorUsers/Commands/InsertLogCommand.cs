using CommonCloud.Repository.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonCloud.Mediator.Commands
{
    /// <summary>
    /// Command Insert log
    /// </summary>
    public record InsertLogCommand(string request, string response) : IRequest<bool>
    {
    }
}
