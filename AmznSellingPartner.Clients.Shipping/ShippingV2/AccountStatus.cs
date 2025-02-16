namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    using System.Runtime.Serialization;

    /// <summary>
    /// Account Status.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AccountStatus
    {
        /// <summary>
        /// Seller Account is Active.
        /// </summary>
        [EnumMember(Value = "ACTIVE")]
        ACTIVE,

        /// <summary>
        /// Seller Account is InActive.
        /// </summary>
        [EnumMember(Value = "INACTIVE")]
        INACTIVE,

        /// <summary>
        /// Seller Account is Pending.
        /// </summary>
        [EnumMember(Value = "PENDING")]
        PENDING,

        /// <summary>
        /// Seller Account is Suspended.
        /// </summary>
        [EnumMember(Value = "SUSPENDED")]
        SUSPENDED,
    }
}
