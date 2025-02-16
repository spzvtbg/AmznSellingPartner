namespace AmznSellingPartner.Clients.MerchantFulfillment.MerchantFulfillmentV0
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    /// <summary>
    /// Request schema.
    /// </summary>
    public class GetAdditionalSellerInputsRequest : BaseClass
    {
        [JsonProperty("ShippingServiceId")]
        [IsRequired]
        public ShippingServiceIdentifier ShippingServiceId { get; set; }

        /// <summary>
        /// The address from which to ship.
        /// </summary>
        [JsonProperty("ShipFromAddress")]
        [IsRequired]
        public Address ShipFromAddress { get; set; }

        /// <summary>
        /// An Amazon defined order identifier
        /// </summary>
        [JsonProperty("OrderId")]
        [IsRequired]
        public AmazonOrderId OrderId { get; set; }
    }
}
