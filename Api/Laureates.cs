using Newtonsoft.Json;
using System.Collections.Generic;

namespace Api
{
    public class Laureates
    {
        [JsonProperty("knownName")]
        public  Name  KnownName{ get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("birth")]
        public Birth BirthInfo { get; set; }

        [JsonProperty("nobelPrizes")]
        public List<NobelPrize> award { get; set; }
    }
}
