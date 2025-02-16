namespace AmznSellingPartner.Clients.Orders.OrdersV0
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    using System.Runtime.Serialization;

    /// <summary>
    /// The verification status of the order.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum VerificationStatus
    {
        /// <summary>
        /// The order is pending approval. Note that the approval might be needed from someone other than
        /// the merchant as determined by the `RequiresMerchantAction` property.
        /// </summary>
        [EnumMember(Value = "Pending")]
        Pending,

        /// <summary>
        /// The order's regulated information has been reviewed and approved.
        /// </summary>
        [EnumMember(Value = "Approved")]
        Approved,

        /// <summary>
        /// The order's regulated information has been reviewed and rejected.
        /// </summary>
        [EnumMember(Value = "Rejected")]
        Rejected,

        /// <summary>
        /// The time to review the order's regulated information has expired.
        /// </summary>
        [EnumMember(Value = "Expired")]
        Expired,

        /// <summary>
        /// The order was cancelled by the purchaser.
        /// </summary>
        [EnumMember(Value = "Cancelled")]
        Cancelled,
    }
}
