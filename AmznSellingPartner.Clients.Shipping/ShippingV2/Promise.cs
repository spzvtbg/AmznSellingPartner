namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
    using Newtonsoft.Json;

    /// <summary>
    /// The time windows promised for pickup and delivery events.
    /// </summary>
    public class Promise : BaseClass
    {
        [JsonProperty("deliveryWindow")]
        public TimeWindow DeliveryWindow { get; set; }

        [JsonProperty("pickupWindow")]
        public TimeWindow PickupWindow { get; set; }
    }
}
