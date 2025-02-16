namespace AmznSellingPartner.Clients.Replenishment.Replenishment20221107
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    using System.Runtime.Serialization;

    /// <summary>
    /// The attribute to use to sort the results.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ListOffersSortKey
    {
        /// <summary>
        /// Sort the offers on the Amazon Standard Identification Number (ASIN).
        /// </summary>
        [EnumMember(Value = "ASIN")]
        ASIN,

        /// <summary>
        /// Sort the offers on the base discount percentage set by the selling partner on the offer.
        /// </summary>
        [EnumMember(Value = "SELLING_PARTNER_FUNDED_BASE_DISCOUNT_PERCENTAGE")]
        SELLING_PARTNER_FUNDED_BASE_DISCOUNT_PERCENTAGE,

        /// <summary>
        /// Sort the offers on the tiered discount percentage set by the selling partner on the offer.
        /// </summary>
        [EnumMember(Value = "SELLING_PARTNER_FUNDED_TIERED_DISCOUNT_PERCENTAGE")]
        SELLING_PARTNER_FUNDED_TIERED_DISCOUNT_PERCENTAGE,

        /// <summary>
        /// Sort the offers on the base discount percentage set by Amazon on the offer.
        /// </summary>
        [EnumMember(Value = "AMAZON_FUNDED_BASE_DISCOUNT_PERCENTAGE")]
        AMAZON_FUNDED_BASE_DISCOUNT_PERCENTAGE,

        /// <summary>
        /// Sort the offers on the tiered discount percentage set by Amazon on the offer.
        /// </summary>
        [EnumMember(Value = "AMAZON_FUNDED_TIERED_DISCOUNT_PERCENTAGE")]
        AMAZON_FUNDED_TIERED_DISCOUNT_PERCENTAGE,
    }
}
