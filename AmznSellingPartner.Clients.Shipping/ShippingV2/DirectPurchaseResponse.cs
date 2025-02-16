namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
    using Newtonsoft.Json;

    /// <summary>
    /// The response schema for the directPurchaseShipment operation.
    /// </summary>
    public class DirectPurchaseResponse : BaseClass
    {
        [JsonProperty("payload")]
        public DirectPurchaseResult Payload { get; set; }
    }
}
