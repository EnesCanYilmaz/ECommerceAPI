using System;
using System.Text.Json.Serialization;

namespace ECommerceAPI.Application.Dtos.Facebook
{
	public class FacebookUserInfoResponse
	{
		[JsonPropertyName("id")]
        public string? Id { get; set; }
        [JsonPropertyName("email")]
        public string? Email { get; set; }
        [JsonPropertyName("name")]
        public string? Name { get; set; }
	}
}

