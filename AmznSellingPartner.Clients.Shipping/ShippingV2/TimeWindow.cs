namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
    using AmznSellingPartner.Clients.Values;

    using Newtonsoft.Json;

    /// <summary>
    /// The start and end time that specifies the time interval of an event.
    /// </summary>
    public class TimeWindow : BaseClass
    {
        /// <summary>
        /// The start time of the time window.
        /// </summary>
        [JsonProperty("start")]
        public DateTimeValue Start { get; set; }

        /// <summary>
        /// The end time of the time window.
        /// </summary>
        [JsonProperty("end")]
        public DateTimeValue End { get; set; }
    }
}
