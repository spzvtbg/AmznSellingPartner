namespace AmznSellingPartner.Clients.Orders.OrdersV0
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    using System.Runtime.Serialization;

    [JsonConverter(typeof(StringEnumConverter))]
    public enum AddressType
    {
        /// <summary>
        /// The shipping address is a residential address.
        /// </summary>
        [EnumMember(Value = "Residential")]
        Residential,

        /// <summary>
        /// The shipping address is a commercial address.
        /// </summary>
        [EnumMember(Value = "Commercial")]
        Commercial,
    }
}
