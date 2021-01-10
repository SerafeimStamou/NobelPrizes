using Newtonsoft.Json;


namespace Api
{
    public class Motivation
    {
        [JsonProperty("en")]
        public string PrizeMotivation { get; set; }
    }
}
