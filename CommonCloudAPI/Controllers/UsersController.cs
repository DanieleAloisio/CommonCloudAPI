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

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<UserModel>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult Get(string email)
        {
            if (email == null)
            {
                return BadRequest(new ErrDto("empty email", StatusCodes.Status400BadRequest));
            }

            var response = _mediator.Send(_mediator.Send(request: new GetUserByEmailQuery(email)));

            if (response == null)
            {
                return StatusCode(404, new ErrDto("users not found.", StatusCodes.Status404NotFound));
            }

            return Ok(response);
        }
    }
}
