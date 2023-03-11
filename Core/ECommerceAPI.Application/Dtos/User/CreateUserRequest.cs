using System;
namespace ECommerceAPI.Application.Dtos.User
{
	public class CreateUserRequest
	{
        public string? FullName { get; set; }
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? PasswordConfirm { get; set; }
    }
}

