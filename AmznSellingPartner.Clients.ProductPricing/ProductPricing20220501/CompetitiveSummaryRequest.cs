namespace AmznSellingPartner.Clients.ProductPricing.ProductPricing20220501
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    using System.Collections.Generic;

    /// <summary>
    /// An individual `competitiveSummary` request for an ASIN and `marketplaceId`.
    /// </summary>
    public class CompetitiveSummaryRequest : BaseClass
    {
        /// <summary>
        /// The Amazon Standard Identification Number for the item.
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
        /// The list of requested competitive pricing data for the product.
        /// </summary>
        [JsonProperty("includedData")]
        [IsRequired]
        [MinItems(1)]
        public List<CompetitiveSummaryIncludedData> IncludedData { get; set; }

        /// <summary>
        /// The list of `lowestPricedOffersInput` parameters that are used to build `lowestPricedOffers`
        /// in the response. This attribute is only valid if `lowestPricedOffers` is requested in `inc
        /// ludedData`
        /// </summary>
        [JsonProperty("lowestPricedOffersInputs")]
        [MinItems(0)]
        [MaxItems(5)]
        public List<LowestPricedOffersInput> LowestPricedOffersInputs { get; set; }

        /// <summary>
        /// HTTP method type
        /// </summary>
        [JsonProperty("method")]
        [IsRequired]
        public HttpMethod Method { get; set; }

        /// <summary>
        /// The URI associated with the individual APIs that are called as part of the batch request. For
        /// `getCompetitiveSummary`, this is `/products/pricing/2022-05-01/items/competitiveSummary`.
        /// </summary>
        [JsonProperty("uri")]
        [IsRequired]
        public HttpUri Uri { get; set; }
    }
}
