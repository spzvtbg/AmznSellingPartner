namespace AmznSellingPartner.Clients.SupplySources.SupplySources20200701
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    using System.Runtime.Serialization;

    /// <summary>
    /// The time unit
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TimeUnit
    {
        [EnumMember(Value = "Hours")]
        Hours,

        [EnumMember(Value = "Minutes")]
        Minutes,

        [EnumMember(Value = "Days")]
        Days,
    }
}
