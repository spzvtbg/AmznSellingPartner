namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    using System.Runtime.Serialization;

    /// <summary>
    /// Specifies whether the fulfillment order should ship now or have an order hold put on it.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FulfillmentAction
    {
        /// <summary>
        /// The fulfillment order ships now.
        /// </summary>
        [EnumMember(Value = "Ship")]
        Ship,

        /// <summary>
        /// An order hold is put on the fulfillment order.
        /// </summary>
        [EnumMember(Value = "Hold")]
        Hold,
    }
}
