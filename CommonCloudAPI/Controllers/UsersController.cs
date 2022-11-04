using CommonCloud.API.Dto;
using CommonCloud.Log.Dto;
using CommonCloud.Repository.Models;
using MediatorUsers.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CommonCloudAPI.Controllers
{
    /// <summary>
    /// API Users DB: COMMONCLOUD
    /// </summary>
    [ApiController]
    [Route("api/users")]
    public class UsersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UsersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("getByEmail/{email}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<AccountReteModel>))]
        public async Task<IActionResult> GetByEmail([FromRoute] string email)
        {
            var response = await _mediator.Send(request: new GetUsersByEmailQuery(email));

            if (response == null || response.Count == 0)
                throw new ItemNotFoundException();

            return Ok(response);
        }

        [HttpGet("getByAccount/{account}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<AccountReteModel>))]
        public async Task<IActionResult> GetByAccount([FromRoute] string account)
        {
            var response = await _mediator.Send(request: new GetUsersByAccountQuery(account));

            if (response == null || response.Count == 0)
                throw new ItemNotFoundException();

            return Ok(response);
        }

        [HttpGet("getByMatricola/{matricola}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<AccountReteModel>))]
        public async Task<IActionResult> GetByMatricola([FromRoute] string matricola)
        {
            var response = await _mediator.Send(request: new GetUsersByMatricolaQuery(matricola));

            if (response == null || response.Count == 0)
                throw new ItemNotFoundException();

            return Ok(response);
        }

        [HttpGet("getByField/{field}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<AccountReteModel>))]
        public async Task<IActionResult> GetByField([FromRoute] string field)
        {
            var response = await _mediator.Send(request: new GetUsersByFieldQuery(field));

            if (response == null || response.Count == 0)
                throw new ItemNotFoundException();

            return Ok(response);
        }
    }
}
