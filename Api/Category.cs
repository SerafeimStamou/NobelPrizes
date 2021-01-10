using Newtonsoft.Json;


namespace Api
{
    public class Category
    {
        [JsonProperty("en")]
        public string CategoryName { get; set; }
    }
}
