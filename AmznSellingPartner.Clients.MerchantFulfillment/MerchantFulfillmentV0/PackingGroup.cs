namespace AmznSellingPartner.Clients.MerchantFulfillment.MerchantFulfillmentV0
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    using System.Runtime.Serialization;

    [JsonConverter(typeof(StringEnumConverter))]
    public enum PackingGroup
    {
        /// <summary>
        /// Packing group I indicates great danger.
        /// </summary>
        [EnumMember(Value = "I")]
        I,

        /// <summary>
        /// Packing group II indicates medium danger.
        /// </summary>
        [EnumMember(Value = "II")]
        II,

        /// <summary>
        /// Packing group III indicates minor danger.
        /// </summary>
        [EnumMember(Value = "III")]
        III,
    }
}
