using ECommerceAPI.Application.Abstractions.Services;
using ECommerceAPI.Application.Abstractions.Token;
using ECommerceAPI.Application.Dtos;
using ECommerceAPI.Domain.Identity;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Application.Features.Commands.AppUserCommand.LoginGoogle
{
    public class LoginGoogleCommandHandler : IRequestHandler<LoginGoogleCommandRequest, LoginGoogleCommandResponse>
    {
        readonly IAuthService _authService;

        public LoginGoogleCommandHandler(IAuthService authService)
        {
            _authService = authService;
        }

        public async Task<LoginGoogleCommandResponse> Handle(LoginGoogleCommandRequest request, CancellationToken cancellationToken)
        {
            var token = await _authService.LoginGoogleAsync(request.IdToken, 2000);

            return new()
            {
                Token = token
            };
        }
    }
}
