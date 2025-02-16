namespace AmznSellingPartner.Clients.ProductPricing.ProductPricing20220501
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    using System.Runtime.Serialization;

    /// <summary>
    /// The supported data types in the `getCompetitiveSummary` API.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CompetitiveSummaryIncludedData
    {
        /// <summary>
        /// Describes the current segmented featured offer information for the item.
        /// </summary>
        [EnumMember(Value = "featuredBuyingOptions")]
        FeaturedBuyingOptions,

        /// <summary>
        /// Provides reference price points for the item, such as the Competitive Price Threshold.
        /// </summary>
        [EnumMember(Value = "referencePrices")]
        ReferencePrices,

        /// <summary>
        /// The lowest-priced standard offers that are available for the item in the Amazon store.
        /// </summary>
        [EnumMember(Value = "lowestPricedOffers")]
        LowestPricedOffers,
    }
}
