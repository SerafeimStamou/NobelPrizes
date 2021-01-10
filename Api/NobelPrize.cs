using Newtonsoft.Json;

namespace Api
{
    public class NobelPrize
    {
        [JsonProperty("awardYear")]
        public string AwardYear { get; set; }


        [JsonProperty("dateAwarded")]
        public string DateAwarded { get; set; }


        [JsonProperty("prizeStatus")]
        public string PrizeStatus { get; set; }

        [JsonProperty("category")]
        public Category Category { get; set; }

        [JsonProperty("categoryFullName")]
        public CategoryFullName CategoryFullName { get; set; }

        [JsonProperty("motivation")]
        public Motivation MotivationText { get; set; }
    }
}
