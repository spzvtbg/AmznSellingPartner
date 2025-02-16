namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
    using AmznSellingPartner.Clients.ValidationAttributes;
    using AmznSellingPartner.Clients.Values;

    using Newtonsoft.Json;

    using System.Collections.Generic;

    /// <summary>
    /// The payload for the getTracking operation.
    /// </summary>
    public class GetTrackingResult : BaseClass
    {
        [JsonProperty("trackingId")]
        [IsRequired]
        public TrackingId TrackingId { get; set; }

        [JsonProperty("alternateLegTrackingId")]
        [IsRequired]
        public AlternateLegTrackingId AlternateLegTrackingId { get; set; }

        /// <summary>
        /// A list of tracking events.
        /// </summary>
        [JsonProperty("eventHistory")]
        [IsRequired]
        public List<Event> EventHistory { get; set; }

        /// <summary>
        /// The date and time by which the shipment is promised to be delivered.
        /// </summary>
        [JsonProperty("promisedDeliveryDate")]
        [IsRequired]
        public DateTimeValue PromisedDeliveryDate { get; set; }

        [JsonProperty("summary")]
        [IsRequired]
        public TrackingSummary Summary { get; set; }
    }
}
