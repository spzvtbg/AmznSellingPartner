namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    /// <summary>
    /// Information for tracking package deliveries.
    /// </summary>
    public class TrackingEvent : BaseClass
    {
        /// <summary>
        /// The date and time that the delivery event took place. Must be in <a href='https://developer-docs.amazon.com/sp-api/docs/iso-8601'>ISO
        /// 8601</a> format.
        /// </summary>
        [JsonProperty("eventDate")]
        [IsRequired]
        public Timestamp EventDate { get; set; }

        /// <summary>
        /// The city where the delivery event took place.
        /// </summary>
        [JsonProperty("eventAddress")]
        [IsRequired]
        public TrackingAddress EventAddress { get; set; }

        /// <summary>
        /// The event code for the delivery event.
        /// </summary>
        [JsonProperty("eventCode")]
        [IsRequired]
        public EventCode EventCode { get; set; }

        /// <summary>
        /// A description for the corresponding event code.
        /// </summary>
        [JsonProperty("eventDescription")]
        [IsRequired]
        public string EventDescription { get; set; }
    }
}
