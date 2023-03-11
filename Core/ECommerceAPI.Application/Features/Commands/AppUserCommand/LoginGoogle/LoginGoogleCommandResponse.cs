using ECommerceAPI.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Application.Features.Commands.AppUserCommand.LoginGoogle
{
    public class LoginGoogleCommandResponse
    {
        public Token? Token { get; set; }
    }
}
