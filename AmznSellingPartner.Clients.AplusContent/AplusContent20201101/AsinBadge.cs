namespace AmznSellingPartner.Clients.AplusContent.AplusContent20201101
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    using System.Runtime.Serialization;

    /// <summary>
    /// A flag that provides additional information about an ASIN. This is contextual and may change
    /// depending on the request that generated it.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AsinBadge
    {
        /// <summary>
        /// This ASIN is not part of the current user's brand. If the current user corrects their brand
        /// registration to include this ASIN, it will lose the `BrandNotEligible` badge.
        /// </summary>
        [EnumMember(Value = "BRAND_NOT_ELIGIBLE")]
        BRAND_NOT_ELIGIBLE,

        /// <summary>
        /// This ASIN was not found in the Amazon catalog. If any user creates or restores this ASIN, it
        /// will lose the `CatalogNotFound` badge.
        /// </summary>
        [EnumMember(Value = "CATALOG_NOT_FOUND")]
        CATALOG_NOT_FOUND,

        /// <summary>
        /// This ASIN does not have the specified A+ Content published to it. If the current user publishes
        /// the specified content for this ASIN, it will lose the `ContentNotPublished` badge.
        /// </summary>
        [EnumMember(Value = "CONTENT_NOT_PUBLISHED")]
        CONTENT_NOT_PUBLISHED,

        /// <summary>
        /// This ASIN has the specified A+ Content published to it. If the current user suspends the specified
        /// content for this ASIN, it will lose the `ContentPublished` badge.
        /// </summary>
        [EnumMember(Value = "CONTENT_PUBLISHED")]
        CONTENT_PUBLISHED,
    }
}
