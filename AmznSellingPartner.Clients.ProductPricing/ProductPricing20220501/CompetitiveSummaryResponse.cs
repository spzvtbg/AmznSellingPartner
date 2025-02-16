namespace AmznSellingPartner.Clients.ProductPricing.ProductPricing20220501
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    /// <summary>
    /// The response for the individual `competitiveSummary` request in the batch operation.
    /// </summary>
    public class CompetitiveSummaryResponse : BaseClass
    {
        /// <summary>
        /// The HTTP status line associated with the response. For more information, refer to [RFC 261
        /// 6](https://www.w3.org/Protocols/rfc2616/rfc2616-sec6.html).
        /// </summary>
        [JsonProperty("status")]
        [IsRequired]
        public HttpStatusLine Status { get; set; }

        /// <summary>
        /// The `competitiveSummaryResponse` body for a requested ASIN and `marketplaceId`.
        /// </summary>
        [JsonProperty("body")]
        [IsRequired]
        public CompetitiveSummaryResponseBody Body { get; set; }
    }
}
