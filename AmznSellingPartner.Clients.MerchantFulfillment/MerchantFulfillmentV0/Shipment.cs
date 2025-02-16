namespace AmznSellingPartner.Clients.MerchantFulfillment.MerchantFulfillmentV0
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    /// <summary>
    /// The details of a shipment. Includes the shipment status.
    /// </summary>
    public class Shipment : BaseClass
    {
        [JsonProperty("ShipmentId")]
        [IsRequired]
        public ShipmentId ShipmentId { get; set; }

        [JsonProperty("AmazonOrderId")]
        [IsRequired]
        public AmazonOrderId AmazonOrderId { get; set; }

        [JsonProperty("SellerOrderId")]
        public SellerOrderId SellerOrderId { get; set; }

        [JsonProperty("ItemList")]
        [IsRequired]
        public ItemList ItemList { get; set; }

        /// <summary>
        /// The address of the sender.
        /// </summary>
        [JsonProperty("ShipFromAddress")]
        [IsRequired]
        public Address ShipFromAddress { get; set; }

        /// <summary>
        /// The destination address for the shipment.
        /// </summary>
        [JsonProperty("ShipToAddress")]
        [IsRequired]
        public Address ShipToAddress { get; set; }

        [JsonProperty("PackageDimensions")]
        [IsRequired]
        public PackageDimensions PackageDimensions { get; set; }

        /// <summary>
        /// The package weight.
        /// </summary>
        [JsonProperty("Weight")]
        [IsRequired]
        public Weight Weight { get; set; }

        /// <summary>
        /// If you specify `DeclaredValue` in a previous call to the `createShipment` operation, then `Insurance`
        /// indicates the shipment insurance amount that the carrier uses. If `DeclaredValue` isn't with
        /// a previous call to the `createShipment` operation, then the shipment is insured for the carrier's
        /// minimum insurance amount, or the combined sale prices that the items are listed for in the
        /// shipment.
        /// </summary>
        [JsonProperty("Insurance")]
        [IsRequired]
        public CurrencyAmount Insurance { get; set; }

        [JsonProperty("ShippingService")]
        [IsRequired]
        public ShippingService ShippingService { get; set; }

        /// <summary>
        /// Data for creating a shipping label and dimensions for printing the label. If the shipment is
        /// canceled, an empty label is returned.
        /// </summary>
        [JsonProperty("Label")]
        [IsRequired]
        public Label Label { get; set; }

        /// <summary>
        /// The shipment status.
        /// </summary>
        [JsonProperty("Status")]
        [IsRequired]
        public ShipmentStatus Status { get; set; }

        [JsonProperty("TrackingId")]
        public TrackingId TrackingId { get; set; }

        /// <summary>
        /// The date and time the shipment is created.
        /// </summary>
        [JsonProperty("CreatedDate")]
        [IsRequired]
        public Timestamp CreatedDate { get; set; }

        /// <summary>
        /// The date and time of the last update.
        /// </summary>
        [JsonProperty("LastUpdatedDate")]
        public Timestamp LastUpdatedDate { get; set; }
    }
}
