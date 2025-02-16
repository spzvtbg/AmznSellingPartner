namespace AmznSellingPartner.Clients.AmazonWarehousingAndDistribution.Awd20240509
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    using System.Runtime.Serialization;

    [JsonConverter(typeof(StringEnumConverter))]
    public enum SortOrder
    {
        /// <summary>
        /// Sorts the collection in ascending order.
        /// </summary>
        [EnumMember(Value = "ASCENDING")]
        ASCENDING,

        /// <summary>
        /// Sorts the collection in descending order.
        /// </summary>
        [EnumMember(Value = "DESCENDING")]
        DESCENDING,
    }
}
