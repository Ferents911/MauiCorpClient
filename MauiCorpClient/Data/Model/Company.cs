using Newtonsoft.Json;

namespace MauiCorpClient.Data.Model
{
	public class Company
	{
        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("name", Required = Required.Always)]
        public string Name { get; set; }

        [JsonProperty("short_description", Required = Required.Always)]
        public string ShortDescription { get; set; }

        [JsonProperty("description", Required = Required.Always)]
        public string Description { get; set; }

        [JsonProperty("location", Required = Required.Always)]
        public string Location { get; set; }

        [JsonProperty("logo")]
        public string Logo { get; set; }

        [JsonProperty("categories", Required = Required.Always)]
        public string Categories { get; set; }

    }
}
