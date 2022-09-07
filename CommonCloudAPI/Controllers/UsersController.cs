using CommonCloudAPI.Models;
using CommonCloudAPI.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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

        //[HttpGet]
        //[ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<UserModel>))]
        //[ProducesResponseType(StatusCodes.Status400BadRequest)]
        //[ProducesResponseType(StatusCodes.Status500InternalServerError)]
        //public async Task<List<UserModel>> Get()
        //{
        //    return await _mediator.Send(new GetAllUsersQuery());
        //}

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<UserModel>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<List<UserModel>> Get(string email)
        {
            return await _mediator.Send(new GetUserByEmailQuery(email));
        }
    }
}
