namespace AmznSellingPartner.Clients.ListingsItems.ListingsItems20210801
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    using System.Runtime.Serialization;

    [JsonConverter(typeof(StringEnumConverter))]
    public enum SortOrder
    {
        /// <summary>
        /// Ascending order.
        /// </summary>
        [EnumMember(Value = "ASC")]
        ASC,

        /// <summary>
        /// Descending order.
        /// </summary>
        [EnumMember(Value = "DESC")]
        DESC,
    }
}
