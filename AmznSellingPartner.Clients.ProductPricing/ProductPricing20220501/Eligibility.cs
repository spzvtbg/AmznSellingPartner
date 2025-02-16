namespace AmznSellingPartner.Clients.ProductPricing.ProductPricing20220501
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    using System.Runtime.Serialization;

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Eligibility
    {
        /// <summary>
        /// Indicates that this offer has Amazon Prime eligibility in all regions within the marketpla
        /// ce.
        /// </summary>
        [EnumMember(Value = "NATIONAL")]
        NATIONAL,

        /// <summary>
        /// Indicates that this offer has Amazon Prime eligibility in some (but not all) regions within
        /// the marketplace.
        /// </summary>
        [EnumMember(Value = "REGIONAL")]
        REGIONAL,

        /// <summary>
        /// Indicates that this offer is not an Amazon Prime offer in any region within the marketplac
        /// e.
        /// </summary>
        [EnumMember(Value = "NONE")]
        NONE,
    }
}
