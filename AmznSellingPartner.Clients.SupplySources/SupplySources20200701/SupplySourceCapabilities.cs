namespace AmznSellingPartner.Clients.SupplySources.SupplySources20200701
{
    using Newtonsoft.Json;

    /// <summary>
    /// The capabilities of a supply source.
    /// </summary>
    public class SupplySourceCapabilities : BaseClass
    {
        [JsonProperty("outbound")]
        public OutboundCapability Outbound { get; set; }

        [JsonProperty("services")]
        public ServicesCapability Services { get; set; }
    }
}
