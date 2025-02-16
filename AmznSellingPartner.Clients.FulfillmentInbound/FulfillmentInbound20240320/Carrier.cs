namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    /// <summary>
    /// The carrier for the inbound shipment.
    /// </summary>
    public class Carrier : BaseClass
    {
        /// <summary>
        /// The carrier code. For example, USPS or DHLEX.
        /// </summary>
        [JsonProperty("alphaCode")]
        [MinLength(1)]
        [MaxLength(1024)]
        public string AlphaCode { get; set; }

        /// <summary>
        /// The name of the carrier.
        /// </summary>
        [JsonProperty("name")]
        [MinLength(1)]
        [MaxLength(1024)]
        public string Name { get; set; }
    }
}
