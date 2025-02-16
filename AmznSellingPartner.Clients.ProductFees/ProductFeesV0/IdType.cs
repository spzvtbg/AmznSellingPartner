namespace AmznSellingPartner.Clients.ProductFees.ProductFeesV0
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    using System.Runtime.Serialization;

    /// <summary>
    /// The type of product identifier used in a `FeesEstimateByIdRequest`.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum IdType
    {
        /// <summary>
        /// An Amazon Standard Identification Number (ASIN) of a listings item.
        /// </summary>
        [EnumMember(Value = "ASIN")]
        ASIN,

        /// <summary>
        /// A selling partner provided identifier for an Amazon listing.
        /// </summary>
        [EnumMember(Value = "SellerSKU")]
        SellerSKU,
    }
}
