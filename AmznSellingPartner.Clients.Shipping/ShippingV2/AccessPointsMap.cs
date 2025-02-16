namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
    using Newtonsoft.Json;

    /// <summary>
    /// Map of type of access point to list of access points
    /// </summary>
    public class AccessPointsMap : BaseClass
    {
        [JsonProperty("")]
        public AccessPointList AdditionalValue { get; set; }
    }
}
