using Newtonsoft.Json;


namespace Api
{
    public class Birth
    {
        [JsonProperty("date")]
        public string BirthDate { get; set; }

        [JsonProperty("place")]
        public Place PlaceInfo { get; set; }
    }
}
