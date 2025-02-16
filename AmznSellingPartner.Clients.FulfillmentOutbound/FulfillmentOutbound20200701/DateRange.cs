namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    /// <summary>
    /// The time range within which something (for example, a delivery) will occur.
    /// </summary>
    public class DateRange : BaseClass
    {
        /// <summary>
        /// The earliest point in a date range.
        /// </summary>
        [JsonProperty("earliest")]
        [IsRequired]
        public Timestamp Earliest { get; set; }

        /// <summary>
        /// The latest point in a date range.
        /// </summary>
        [JsonProperty("latest")]
        [IsRequired]
        public Timestamp Latest { get; set; }
    }
}
