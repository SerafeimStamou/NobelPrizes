using Newtonsoft.Json;


namespace Api
{
    public class Country
    {
        [JsonProperty("en")]
        public string CountryName { get; set; }
    }
}
