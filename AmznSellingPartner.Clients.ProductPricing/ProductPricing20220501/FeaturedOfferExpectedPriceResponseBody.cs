namespace AmznSellingPartner.Clients.ProductPricing.ProductPricing20220501
{
    using Newtonsoft.Json;

    /// <summary>
    /// The FOEP response data for a requested SKU.
    /// </summary>
    public class FeaturedOfferExpectedPriceResponseBody : BaseClass
    {
        /// <summary>
        /// Metadata that identifies the target offer for which the FOEP result data was computed.
        /// </summary>
        [JsonProperty("offerIdentifier")]
        public OfferIdentifier OfferIdentifier { get; set; }

        /// <summary>
        /// The FOEP results for the requested target offer.
        /// </summary>
        [JsonProperty("featuredOfferExpectedPriceResults")]
        public FeaturedOfferExpectedPriceResultList FeaturedOfferExpectedPriceResults { get; set; }

        /// <summary>
        /// The errors that occurred if the operation wasn't successful (HTTP status code non-200).
        /// </summary>
        [JsonProperty("errors")]
        public ErrorList Errors { get; set; }
    }
}
