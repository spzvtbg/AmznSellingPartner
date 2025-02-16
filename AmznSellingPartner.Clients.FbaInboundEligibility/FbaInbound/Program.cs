namespace AmznSellingPartner.Clients.FbaInboundEligibility.FbaInbound
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    using System.Runtime.Serialization;

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Program
    {
        [EnumMember(Value = "INBOUND")]
        INBOUND,

        [EnumMember(Value = "COMMINGLING")]
        COMMINGLING,
    }
}
