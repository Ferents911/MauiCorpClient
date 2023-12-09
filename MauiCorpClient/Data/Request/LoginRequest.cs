using Newtonsoft.Json;

namespace MauiCorpClient.Data.Request
{
	public class LoginRequest
	{
		[JsonProperty("email", Required = Required.Always)]
		public string Email { get; set; }

		[JsonProperty("password", Required = Required.Always)]
		public string Password { get; set; }
	}
}
