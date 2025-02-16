namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    /// <summary>
    /// The amount to collect on delivery.
    /// </summary>
    public class CollectOnDelivery : BaseClass
    {
        [JsonProperty("amount")]
        [IsRequired]
        public Currency Amount { get; set; }
    }
}
