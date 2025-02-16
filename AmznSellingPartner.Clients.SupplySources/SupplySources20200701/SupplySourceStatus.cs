namespace AmznSellingPartner.Clients.SupplySources.SupplySources20200701
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    using System.Runtime.Serialization;

    /// <summary>
    /// The `SupplySource` status
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SupplySourceStatus
    {
        [EnumMember(Value = "Active")]
        Active,

        [EnumMember(Value = "Inactive")]
        Inactive,
    }
}
