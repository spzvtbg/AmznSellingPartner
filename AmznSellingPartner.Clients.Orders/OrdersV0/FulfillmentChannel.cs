namespace AmznSellingPartner.Clients.Orders.OrdersV0
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    using System.Runtime.Serialization;

    [JsonConverter(typeof(StringEnumConverter))]
    public enum FulfillmentChannel
    {
        /// <summary>
        /// Fulfilled by the seller.
        /// </summary>
        [EnumMember(Value = "MFN")]
        MFN,

        /// <summary>
        /// Fulfilled by Amazon.
        /// </summary>
        [EnumMember(Value = "AFN")]
        AFN,
    }
}
