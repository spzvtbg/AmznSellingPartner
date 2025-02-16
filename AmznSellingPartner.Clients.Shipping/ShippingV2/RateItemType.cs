namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    using System.Runtime.Serialization;

    /// <summary>
    /// Type of the rateItem.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RateItemType
    {
        /// <summary>
        /// Rate Item is mandatory.
        /// </summary>
        [EnumMember(Value = "MANDATORY")]
        MANDATORY,

        /// <summary>
        /// Rate Item is Optional.
        /// </summary>
        [EnumMember(Value = "OPTIONAL")]
        OPTIONAL,

        /// <summary>
        /// Rate Item is included.
        /// </summary>
        [EnumMember(Value = "INCLUDED")]
        INCLUDED,
    }
}
