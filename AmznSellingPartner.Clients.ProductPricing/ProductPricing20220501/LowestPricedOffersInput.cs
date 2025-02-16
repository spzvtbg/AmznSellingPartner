namespace AmznSellingPartner.Clients.ProductPricing.ProductPricing20220501
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    /// <summary>
    /// The input required for building `LowestPricedOffers` data in the response.
    /// </summary>
    public class LowestPricedOffersInput : BaseClass
    {
        /// <summary>
        /// The input parameter specifies the `itemCondition` of the offer that is requested for `LowestPricedOffers`.
        /// `New` is the default value for `itemCondition`.
        /// </summary>
        [JsonProperty("itemCondition")]
        [IsRequired]
        public Condition ItemCondition { get; set; }

        /// <summary>
        /// The input parameter specifies the type of offers requested for `LowestPricedOffers`. This applies
        /// to `Consumer` and `Business` offers. `Consumer` is the default `offerType`.
        /// </summary>
        [JsonProperty("offerType")]
        [IsRequired]
        public OfferType OfferType { get; set; }
    }
}
