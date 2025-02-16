namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    using System.Runtime.Serialization;

    [JsonConverter(typeof(StringEnumConverter))]
    public enum AssistanceType
    {
        [EnumMember(Value = "STAFF_ASSISTED")]
        STAFF_ASSISTED,

        [EnumMember(Value = "SELF_ASSISTED")]
        SELF_ASSISTED,
    }
}
