using System;
using MediatR;

namespace ECommerceAPI.Application.Features.Commands.AppUserCommand.LoginFacebook
{
	public class LoginFacebookCommandRequest : IRequest<LoginFacebookCommandResponse>
	{
		public string? AuthToken { get; set; }
	}
}

