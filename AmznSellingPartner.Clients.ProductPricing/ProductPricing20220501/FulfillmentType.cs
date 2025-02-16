namespace AmznSellingPartner.Clients.ProductPricing.ProductPricing20220501
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    using System.Runtime.Serialization;

    /// <summary>
    /// Indicates whether the item is fulfilled by Amazon or by the seller (merchant).
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FulfillmentType
    {
        /// <summary>
        /// Fulfilled by Amazon.
        /// </summary>
        [EnumMember(Value = "AFN")]
        AFN,

        /// <summary>
        /// Fulfilled by the seller.
        /// </summary>
        [EnumMember(Value = "MFN")]
        MFN,
    }
}
