using System;
using System.Text.Json;
using ECommerceAPI.Application.Abstractions.Services;
using ECommerceAPI.Application.Abstractions.Token;
using ECommerceAPI.Application.Dtos;
using ECommerceAPI.Application.Dtos.Facebook;
using ECommerceAPI.Domain.Identity;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace ECommerceAPI.Application.Features.Commands.AppUserCommand.LoginFacebook
{
	public class LoginFacebookCommandHandler : IRequestHandler<LoginFacebookCommandRequest, LoginFacebookCommandResponse>
	{
        readonly IAuthService _authService;

        public LoginFacebookCommandHandler(IAuthService authService)
        {
            _authService = authService;
        }

        public async Task<LoginFacebookCommandResponse> Handle(LoginFacebookCommandRequest request, CancellationToken cancellationToken)
        {
            var token = await _authService.LoginFacebookAsync(request.AuthToken, 15);


            return new()
            {
                Token = token
            };
        }
    }
}

