using Newtonsoft.Json;


namespace Api
{
    public class City
    {
        [JsonProperty("en")]
        public string  CityName { get; set; }
    }
}
