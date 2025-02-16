namespace AmznSellingPartner.Clients.VendorOrders.VendorOrders
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    using System.Runtime.Serialization;

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ConfirmationStatus
    {
        /// <summary>
        /// Status for orders accepted by vendors.
        /// </summary>
        [EnumMember(Value = "ACCEPTED")]
        ACCEPTED,

        /// <summary>
        /// Status for orders that are partially accepted by vendors.
        /// </summary>
        [EnumMember(Value = "PARTIALLY_ACCEPTED")]
        PARTIALLY_ACCEPTED,

        /// <summary>
        /// Status for orders that are rejected by vendors.
        /// </summary>
        [EnumMember(Value = "REJECTED")]
        REJECTED,

        /// <summary>
        /// Status for orders that are yet to be confirmed by vendors.
        /// </summary>
        [EnumMember(Value = "UNCONFIRMED")]
        UNCONFIRMED,
    }
}
