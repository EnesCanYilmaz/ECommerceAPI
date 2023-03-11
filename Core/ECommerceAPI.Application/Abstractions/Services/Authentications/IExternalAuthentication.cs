using System;
namespace ECommerceAPI.Application.Abstractions.Services.Authentications
{
	public interface IExternalAuthentication
	{
        Task<Dtos.Token> LoginFacebookAsync(string authToken, int accessTokenLifeTime);
        Task<Dtos.Token> LoginGoogleAsync(string idToken , int accessTokenLifeTime);
    }
}

