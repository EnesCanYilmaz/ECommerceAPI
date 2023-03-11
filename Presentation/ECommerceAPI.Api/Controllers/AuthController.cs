using ECommerceAPI.Application.Features.Commands.AppUserCommand.LoginFacebook;
using ECommerceAPI.Application.Features.Commands.AppUserCommand.LoginGoogle;
using ECommerceAPI.Application.Features.Commands.AppUserCommand.LoginUser;
using MediatR;
using Microsoft.AspNetCore.Mvc;


namespace ECommerceAPI.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        readonly IMediator _mediator;

        public AuthController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> LoginUser(LoginUserCommandRequest loginUserCommandRequest)
        {
            LoginUserCommandResponse response = await _mediator.Send(loginUserCommandRequest);
            return Ok(response);
        }
        [HttpPost("google-login")]
        public async Task<IActionResult> LoginGoogle(LoginGoogleCommandRequest loginGoogleCommandRequest)
        {
            LoginGoogleCommandResponse response = await _mediator.Send(loginGoogleCommandRequest);
            return Ok(response);
        }
        [HttpPost("facebook-login")]
        public async Task<IActionResult> LoginFacebook(LoginFacebookCommandRequest loginFacebookCommandRequest)
        {
            LoginFacebookCommandResponse response = await _mediator.Send(loginFacebookCommandRequest);
            return Ok(response);
        }
    }
}

