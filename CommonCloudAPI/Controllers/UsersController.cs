using CommonCloud.API.Dto;
using MediatorUsers.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepositoryUsers.Models;

namespace CommonCloudAPI.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Route("api/users")]
    public class UsersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UsersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("getByEmail/{email}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<UserModel>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetByEmail([FromRoute] string email)
        {
            if (email == null)
            {
                return BadRequest(new ErrDto("empty email", StatusCodes.Status400BadRequest));
            }

            var response = await _mediator.Send(request: new GetUsersByEmailQuery(email));

            if (response == null || response.Count == 0)
            {
                return NotFound(new ErrDto("users not found.", StatusCodes.Status404NotFound));
            }

            return Ok(response);
        }

        [HttpGet("getByAccount/{account}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<UserModel>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetByAccount([FromRoute] string account)
        {
            if (account == null)
            {
                return BadRequest(new ErrDto("empty account", StatusCodes.Status400BadRequest));
            }

            var response = await _mediator.Send(request: new GetUsersByAccountQuery(account));

            if (response == null || response.Count == 0)
            {
                return NotFound(new ErrDto("users not found.", StatusCodes.Status404NotFound));
            }

            return Ok(response);
        }

        [HttpGet("getByMatricola/{matricola}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<UserModel>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetByMatricola([FromRoute] string matricola)
        {
            if (matricola == null)
            {
                return BadRequest(new ErrDto("empty matricola", StatusCodes.Status400BadRequest));
            }

            var response = await _mediator.Send(request: new GetUsersByMatricolaQuery(matricola));

            if (response == null || response.Count == 0)
            {
                return NotFound(new ErrDto("users not found.", StatusCodes.Status404NotFound));
            }

            return Ok(response);
        }

        [HttpGet("getByField/{field}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<UserModel>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetByField([FromRoute] string field)
        {
            if (field == null)
            {
                return BadRequest(new ErrDto("empty field.", StatusCodes.Status400BadRequest));
            }

            var response = await _mediator.Send(request: new GetUsersByFieldQuery(field));

            if (response == null || response.Count == 0)
            {
                return NotFound(new ErrDto("users not found.", StatusCodes.Status404NotFound));
            }

            return Ok(response);
        }
    }
}
