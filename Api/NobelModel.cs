using Newtonsoft.Json;
using System.Collections.Generic;

namespace Api
{
    public class NobelModel
    {
        [JsonProperty("laureates")]
        public List<Laureates> Laureates { get; set; }
    }
}
