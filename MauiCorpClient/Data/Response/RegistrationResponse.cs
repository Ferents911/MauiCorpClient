using Newtonsoft.Json;

namespace MauiCorpClient.Data.Response
{
	public class RegistrationResponse
	{
		[JsonProperty("message", Required = Required.Always)]
		public string Message { get; set; }

		[JsonProperty("token", Required = Required.Always)]
		public string Token { get; set; }
	}
}
