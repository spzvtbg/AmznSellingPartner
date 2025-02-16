namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
    using Newtonsoft.Json;

    /// <summary>
    /// A package status summary.
    /// </summary>
    public class TrackingSummary : BaseClass
    {
        [JsonProperty("status")]
        public Status Status { get; set; }
    }
}
