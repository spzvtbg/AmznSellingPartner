namespace AmznSellingPartner.Clients.SupplySources.SupplySources20200701
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    using System.Runtime.Serialization;

    /// <summary>
    /// The throughput unit
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ThroughputUnit
    {
        [EnumMember(Value = "Order")]
        Order,
    }
}
