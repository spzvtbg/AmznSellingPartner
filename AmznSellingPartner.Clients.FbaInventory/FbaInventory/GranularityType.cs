namespace AmznSellingPartner.Clients.FbaInventory.FbaInventory
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    using System.Runtime.Serialization;

    [JsonConverter(typeof(StringEnumConverter))]
    public enum GranularityType
    {
        /// <summary>
        /// Marketplace
        /// </summary>
        [EnumMember(Value = "Marketplace")]
        Marketplace,
    }
}
