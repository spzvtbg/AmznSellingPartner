namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    /// <summary>
    /// Carrier Related Info
    /// </summary>
    public class Carrier : BaseClass
    {
        [JsonProperty("id")]
        [IsRequired]
        public CarrierId Id { get; set; }

        [JsonProperty("name")]
        [IsRequired]
        public CarrierName Name { get; set; }
    }
}
