namespace AmznSellingPartner.Clients.ProductPricing.ProductPricing20220501
{
    using Newtonsoft.Json;

    /// <summary>
    /// A mapping of additional HTTP headers to send or receive for an individual request within a
    /// batch.
    /// </summary>
    public class HttpHeaders : BaseClass
    {
        [JsonProperty("")]
        public string AdditionalValue { get; set; }
    }
}
