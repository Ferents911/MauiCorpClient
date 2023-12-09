using Newtonsoft.Json;

namespace MauiCorpClient.Data.Request
{
    public class RegistrationRequest
    {
        [JsonProperty("name", Required = Required.Always)]
        public string Name { get; set; }

        [JsonProperty("email", Required = Required.Always)]
        public string Email { get; set; }

        [JsonProperty("password", Required = Required.Always)]
        public string Password { get; set; }

        [JsonProperty("r_password", Required = Required.Always)]
        public string RPassword { get; set; }

    }
}
