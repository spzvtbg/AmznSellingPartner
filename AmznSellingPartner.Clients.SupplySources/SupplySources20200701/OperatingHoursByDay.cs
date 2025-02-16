namespace AmznSellingPartner.Clients.SupplySources.SupplySources20200701
{
    using Newtonsoft.Json;

    /// <summary>
    /// The operating hours per day
    /// </summary>
    public class OperatingHoursByDay : BaseClass
    {
        [JsonProperty("monday")]
        public OperatingHours Monday { get; set; }

        [JsonProperty("tuesday")]
        public OperatingHours Tuesday { get; set; }

        [JsonProperty("wednesday")]
        public OperatingHours Wednesday { get; set; }

        [JsonProperty("thursday")]
        public OperatingHours Thursday { get; set; }

        [JsonProperty("friday")]
        public OperatingHours Friday { get; set; }

        [JsonProperty("saturday")]
        public OperatingHours Saturday { get; set; }

        [JsonProperty("sunday")]
        public OperatingHours Sunday { get; set; }
    }
}
