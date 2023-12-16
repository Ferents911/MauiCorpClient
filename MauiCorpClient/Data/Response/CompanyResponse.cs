using MauiCorpClient.Data.Model;
using Newtonsoft.Json;

namespace MauiCorpClient.Data.Response
{
    public class CompanyResponse
    {
        [JsonProperty("data", Required = Required.Always)]
        public List<Company> Companies = new List<Company>();
    }
}
