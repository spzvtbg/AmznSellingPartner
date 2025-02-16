namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
    using Newtonsoft.Json;

    /// <summary>
    /// The response schema for the OneClickShipment operation.
    /// </summary>
    public class OneClickShipmentResponse : BaseClass
    {
        [JsonProperty("payload")]
        public OneClickShipmentResult Payload { get; set; }
    }
}
