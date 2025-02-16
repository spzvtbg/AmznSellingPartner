namespace AmznSellingPartner.Clients.Services.Services
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    using System.Runtime.Serialization;

    [JsonConverter(typeof(StringEnumConverter))]
    public enum SortOrder
    {
        /// <summary>
        /// Sort in ascending order.
        /// </summary>
        [EnumMember(Value = "ASC")]
        ASC,

        /// <summary>
        /// Sort in descending order.
        /// </summary>
        [EnumMember(Value = "DESC")]
        DESC,
    }
}
