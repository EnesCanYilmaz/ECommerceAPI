using System;
using System.Text.Json.Serialization;

namespace ECommerceAPI.Application.Dtos.Facebook
{
	public class FacebookUserAccessTokenValidation
	{
        [JsonPropertyName("data")]
        public FacebookUserAccessTokenValidationData? Data { get; set; }
    }
	public class FacebookUserAccessTokenValidationData
    {

        [JsonPropertyName("is_valid")]
        public bool IsValid { get; set; }
        [JsonPropertyName("user_id")]
        public string? UserId { get; set; }
    }
}

