namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
    using Newtonsoft.Json;

    public class AccessPointDetails : BaseClass
    {
        [JsonProperty("accessPointId")]
        public AccessPointId AccessPointId { get; set; }
    }
}
