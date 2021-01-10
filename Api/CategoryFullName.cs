using Newtonsoft.Json;


namespace Api
{
    public class CategoryFullName
    {
        [JsonProperty("en")]
        public string FullName { get; set; }
    }
}
