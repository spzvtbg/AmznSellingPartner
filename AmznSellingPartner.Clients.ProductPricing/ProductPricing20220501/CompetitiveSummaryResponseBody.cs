namespace AmznSellingPartner.Clients.ProductPricing.ProductPricing20220501
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    using System.Collections.Generic;

    /// <summary>
    /// The `competitiveSummaryResponse` body for a requested ASIN and `marketplaceId`.
    /// </summary>
    public class CompetitiveSummaryResponseBody : BaseClass
    {
        /// <summary>
        /// The Amazon identifier for the item.
        /// </summary>
        [JsonProperty("asin")]
        [IsRequired]
        public Asin Asin { get; set; }

        /// <summary>
        /// A marketplace identifier.
        /// </summary>
        [JsonProperty("marketplaceId")]
        [IsRequired]
        public MarketplaceId MarketplaceId { get; set; }

        /// <summary>
        /// A list of featured buying options for the specified ASIN `marketplaceId` combination.
        /// </summary>
        [JsonProperty("featuredBuyingOptions")]
        public List<FeaturedBuyingOption> FeaturedBuyingOptions { get; set; }

        /// <summary>
        /// A list of lowest priced offers for the specified ASIN `marketplaceId` combination.
        /// </summary>
        [JsonProperty("lowestPricedOffers")]
        public List<LowestPricedOffer> LowestPricedOffers { get; set; }

        /// <summary>
        /// A list of reference prices for the specified ASIN `marketplaceId` combination.
        /// </summary>
        [JsonProperty("referencePrices")]
        public List<ReferencePrice> ReferencePrices { get; set; }

        /// <summary>
        /// A list of errors
        /// </summary>
        [JsonProperty("errors")]
        public ErrorList Errors { get; set; }
    }
}
