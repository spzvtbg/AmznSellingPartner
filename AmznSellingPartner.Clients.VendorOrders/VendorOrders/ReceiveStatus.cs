namespace AmznSellingPartner.Clients.VendorOrders.VendorOrders
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    using System.Runtime.Serialization;

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ReceiveStatus
    {
        /// <summary>
        /// The buyer has not received any of the item.
        /// </summary>
        [EnumMember(Value = "NOT_RECEIVED")]
        NOT_RECEIVED,

        [EnumMember(Value = "PARTIALLY_RECEIVED")]
        PARTIALLY_RECEIVED,

        /// <summary>
        /// Receiving is complete. The buyer has received all confirmed items.
        /// </summary>
        [EnumMember(Value = "RECEIVED")]
        RECEIVED,

        /// <summary>
        /// The buyer has received some of the item and is expecting to receive the rest of the confirmed
        /// quantity.
        /// </summary>
        [EnumMember(Value = "PARTIALLY_RECEIVE")]
        PARTIALLY_RECEIVE,
    }
}
