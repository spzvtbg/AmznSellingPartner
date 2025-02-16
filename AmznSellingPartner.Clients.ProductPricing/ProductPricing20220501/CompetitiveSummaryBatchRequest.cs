namespace AmznSellingPartner.Clients.ProductPricing.ProductPricing20220501
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    /// <summary>
    /// The `competitiveSummary` batch request data.
    /// </summary>
    public class CompetitiveSummaryBatchRequest : BaseClass
    {
        /// <summary>
        /// A batched list of `competitiveSummary` requests.
        /// </summary>
        [JsonProperty("requests")]
        [IsRequired]
        public CompetitiveSummaryRequestList Requests { get; set; }
    }
}
