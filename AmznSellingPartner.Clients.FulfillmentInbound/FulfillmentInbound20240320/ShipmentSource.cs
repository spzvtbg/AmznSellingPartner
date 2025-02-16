namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    /// <summary>
    /// Specifies the 'ship from' address for the shipment.
    /// </summary>
    public class ShipmentSource : BaseClass
    {
        [JsonProperty("address")]
        public Address Address { get; set; }

        /// <summary>
        /// The type of source for this shipment. Possible values: `SELLER_FACILITY`.
        /// </summary>
        [JsonProperty("sourceType")]
        [IsRequired]
        [MinLength(1)]
        [MaxLength(1024)]
        public string SourceType { get; set; }
    }
}
