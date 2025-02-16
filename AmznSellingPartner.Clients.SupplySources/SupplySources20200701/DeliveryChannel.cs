namespace AmznSellingPartner.Clients.SupplySources.SupplySources20200701
{
    using Newtonsoft.Json;

    /// <summary>
    /// The delivery channel of a supply source.
    /// </summary>
    public class DeliveryChannel : BaseClass
    {
        [JsonProperty("isSupported")]
        public bool IsSupported { get; set; }

        [JsonProperty("operationalConfiguration")]
        public OperationalConfiguration OperationalConfiguration { get; set; }
    }
}
