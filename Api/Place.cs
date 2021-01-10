using Newtonsoft.Json;


namespace Api
{
    public class Place
    {
        [JsonProperty("city")]
        public City city { get; set; }

        [JsonProperty("country")]
        public Country country { get; set; }
    }
}
