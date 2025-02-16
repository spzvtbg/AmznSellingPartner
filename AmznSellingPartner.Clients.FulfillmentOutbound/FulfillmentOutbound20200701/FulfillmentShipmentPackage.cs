namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    /// <summary>
    /// Package information for a shipment in a fulfillment order.
    /// </summary>
    public class FulfillmentShipmentPackage : BaseClass
    {
        /// <summary>
        /// Identifies a package in a shipment.
        /// </summary>
        [JsonProperty("packageNumber")]
        [IsRequired]
        public int PackageNumber { get; set; }

        /// <summary>
        /// Identifies the carrier who will deliver the shipment to the recipient.
        /// </summary>
        [JsonProperty("carrierCode")]
        [IsRequired]
        public string CarrierCode { get; set; }

        /// <summary>
        /// The tracking number, if provided, can be used to obtain tracking and delivery information.
        /// </summary>
        [JsonProperty("trackingNumber")]
        public string TrackingNumber { get; set; }

        /// <summary>
        /// The estimated arrival date and time of the package. Must be in <a href='https://developer-docs.amazon.com/sp-api/docs/iso-8601'>ISO
        /// 8601</a> format.
        /// </summary>
        [JsonProperty("estimatedArrivalDate")]
        public Timestamp EstimatedArrivalDate { get; set; }

        /// <summary>
        /// The locker details, if provided can be used to access locker delivery box.
        /// </summary>
        [JsonProperty("lockerDetails")]
        public LockerDetails LockerDetails { get; set; }

        /// <summary>
        /// The delivery information for the package. This information is available after the package is
        /// delivered.
        /// </summary>
        [JsonProperty("deliveryInformation")]
        public DeliveryInformation DeliveryInformation { get; set; }
    }
}
