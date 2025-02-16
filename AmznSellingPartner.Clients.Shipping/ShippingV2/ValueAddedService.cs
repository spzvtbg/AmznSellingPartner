namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    /// <summary>
    /// A value-added service available for purchase with a shipment service offering.
    /// </summary>
    public class ValueAddedService : BaseClass
    {
        /// <summary>
        /// The identifier for the value-added service.
        /// </summary>
        [JsonProperty("id")]
        [IsRequired]
        public string Id { get; set; }

        /// <summary>
        /// The name of the value-added service.
        /// </summary>
        [JsonProperty("name")]
        [IsRequired]
        public string Name { get; set; }

        /// <summary>
        /// The cost of the value-added service.
        /// </summary>
        [JsonProperty("cost")]
        [IsRequired]
        public Currency Cost { get; set; }
    }
}
