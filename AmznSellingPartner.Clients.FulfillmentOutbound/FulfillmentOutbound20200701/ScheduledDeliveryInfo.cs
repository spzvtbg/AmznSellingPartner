namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    /// <summary>
    /// Delivery information for a scheduled delivery. This is only available in the JP marketplac
    /// e.
    /// </summary>
    public class ScheduledDeliveryInfo : BaseClass
    {
        /// <summary>
        /// The time zone of the destination address for the fulfillment order preview. Must be an IANA
        /// time zone name. Example: Asia/Tokyo.
        /// </summary>
        [JsonProperty("deliveryTimeZone")]
        [IsRequired]
        public string DeliveryTimeZone { get; set; }

        /// <summary>
        /// An array of time ranges that are available for scheduled delivery.
        /// </summary>
        [JsonProperty("deliveryWindows")]
        [IsRequired]
        public DeliveryWindowList DeliveryWindows { get; set; }
    }
}
