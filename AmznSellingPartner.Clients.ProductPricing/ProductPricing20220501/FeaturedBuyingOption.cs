namespace AmznSellingPartner.Clients.ProductPricing.ProductPricing20220501
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    using System.Collections.Generic;

    /// <summary>
    /// Describes a featured buying option, which includes a list of segmented featured offers for
    /// a particular item condition.
    /// </summary>
    public class FeaturedBuyingOption : BaseClass
    {
        /// <summary>
        /// The buying option type for the featured offer. `buyingOptionType` represents the buying options
        /// that a customer receives on the detail page, such as `B2B`, `Fresh`, and `Subscribe n Save`.
        /// `buyingOptionType` currently supports `NEW` as a value.
        /// </summary>
        [JsonProperty("buyingOptionType")]
        [IsRequired]
        public BuyingOptionType BuyingOptionType { get; set; }

        /// <summary>
        /// A list of segmented featured offers for the current buying option type. A segment can be considered
        /// as a group of regional contexts that all have the same featured offer. A regional context is
        /// a combination of factors such as customer type, region, or postal code and buying option.
        /// </summary>
        [JsonProperty("segmentedFeaturedOffers")]
        [IsRequired]
        [MinItems(1)]
        public List<SegmentedFeaturedOffer> SegmentedFeaturedOffers { get; set; }
    }
}
